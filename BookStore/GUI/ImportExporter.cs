using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class ImportExporter
    {
        public static void ExportToWordAndPdf(DataGridView dgvDsSanPham, Label lblMaPN, Label lblNgayNhapSach, Label lblTenNCC, Label lblTongTien)
        {
            // Đường dẫn tới tệp Word mẫu
            string templatePath = @"C:\PhieuNhap\PhieuNhapTemplate.docx";
            string folderPath = @"C:\PhieuNhap";
            string wordFilePath = System.IO.Path.Combine(folderPath, "PhieuNhap.docx");
            string pdfFilePath = System.IO.Path.Combine(folderPath, "PhieuNhap.pdf");

            // Kiểm tra nếu thư mục chưa tồn tại thì tạo mới
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            // Mở tệp Word mẫu
            Document document = new Document();
            document.LoadFromFile(templatePath);

            // Thay thế các placeholder trong tệp Word
            document.Replace("{Mã phiếu nhập:}", lblMaPN.Text, false, true);
            document.Replace("{Ngày nhập sách:}", lblNgayNhapSach.Text, false, true);
            document.Replace("{Tên nhà cung cấp:}", lblTenNCC.Text, false, true);
            document.Replace("{Tổng tiền nhập:}", lblTongTien.Text, false, true);

            // Thêm dữ liệu sản phẩm vào bảng (giả sử bảng có trong tệp mẫu)
            Table table = document.Sections[0].Tables[0] as Table;

            // Thêm dữ liệu vào bảng
            for (int i = 0; i < dgvDsSanPham.RowCount; i++)
            {
                TableRow newRow = table.AddRow();
                for (int j = 0; j < dgvDsSanPham.ColumnCount; j++)
                {
                    newRow.Cells[j].AddParagraph().AppendText(dgvDsSanPham.Rows[i].Cells[j].Value?.ToString() ?? "");
                }
            }

            // Lưu tệp Word với thông tin mới
            document.SaveToFile(wordFilePath, Spire.Doc.FileFormat.Docx);

            // Sau khi lưu file Word thành công, tiến hành chuyển đổi sang PDF
            try
            {
                // Sử dụng Spire.Doc để chuyển đổi từ .docx sang .pdf
                document.SaveToFile(pdfFilePath, Spire.Doc.FileFormat.PDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi chuyển đổi sang PDF: {ex.Message}");
            }
        }
    }
}
