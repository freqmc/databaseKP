using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace databaseKP.Utils
{
    public static class Exporter
    {
        public static void ExportToExcel(DataGridView dgv, string fileName)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Создаем экземпляр Excel
                excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.DisplayAlerts = false; // Отключаем предупреждения

                workbook = excelApp.Workbooks.Add();
                worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                // 1. Записываем заголовки столбцов
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                // 2. Записываем данные
                for (int r = 0; r < dgv.Rows.Count; r++)
                {
                    if (dgv.Rows[r].IsNewRow) continue; // Пропускаем строку для новой записи

                    for (int c = 0; c < dgv.Columns.Count; c++)
                    {
                        worksheet.Cells[r + 2, c + 1] = dgv.Rows[r].Cells[c].Value?.ToString() ?? "";
                    }
                }

                // 3. Форматирование: автоподбор ширины столбцов
                Excel.Range range = worksheet.UsedRange;
                range.Columns.AutoFit();

                // Выделение заголовков жирным
                Excel.Range headerRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgv.Columns.Count]];
                headerRange.Font.Bold = true;
                headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                // 4. Сохранение файла
                workbook.SaveAs(fileName);
                MessageBox.Show("Экспорт в Excel выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка экспорта в Excel: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 5. Обязательное освобождение COM-объектов для предотвращения утечек памяти
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);

                // Принудительный вызов сборщика мусора
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        public static void ExportToWord(DataGridView dgv, string fileName)
        {
            Word.Application wordApp = null;
            Word.Document doc = null;

            try
            {
                // Создаем экземпляр Word
                wordApp = new Word.Application();
                wordApp.Visible = false;
                doc = wordApp.Documents.Add();

                // Подсчет реального количества строк данных (без строки "новая запись")
                int rowCount = 0;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow) rowCount++;
                }
                int colCount = dgv.Columns.Count;

                // Создание таблицы в Word (строки + 1 для заголовка, столбцы)
                Word.Range range = doc.Range();
                Word.Table table = doc.Tables.Add(range, rowCount + 1, colCount);
                table.Borders.Enable = 1; // Включаем границы таблицы

                // 1. Записываем заголовки
                for (int c = 0; c < colCount; c++)
                {
                    table.Cell(1, c + 1).Range.Text = dgv.Columns[c].HeaderText;
                    table.Cell(1, c + 1).Range.Bold = 1;
                    table.Cell(1, c + 1).Shading.BackgroundPatternColor = Word.WdColor.wdColorGray15;
                }

                // 2. Записываем данные
                int rowIndex = 2;
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    for (int c = 0; c < colCount; c++)
                    {
                        table.Cell(rowIndex, c + 1).Range.Text = row.Cells[c].Value?.ToString() ?? "";
                    }
                    rowIndex++;
                }

                // 3. Автоподбор таблицы по содержимому
                table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent);

                // 4. Сохранение файла
                doc.SaveAs2(fileName);
                MessageBox.Show("Экспорт в Word выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка экспорта в Word: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 5. Освобождение COM-объектов
                if (doc != null)
                {
                    doc.Close(false);
                    Marshal.ReleaseComObject(doc);
                }
                if (wordApp != null)
                {
                    wordApp.Quit();
                    Marshal.ReleaseComObject(wordApp);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}