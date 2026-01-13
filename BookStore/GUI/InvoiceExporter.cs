using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace GUI
{
    public class InvoiceExporter
    {      

        public static void ExportToWordAndPdf(DataGridView dgvDsSanPham, Label lblMaDH, Label lblNgayMuaHang, Label lblHoTenKH,
                                      Label lblEmail, Label lblDiaChi, Label lblSĐT, Label lblTongTien)
        {
            // Đường dẫn tới tệp Word mẫu
            string templatePath = @"C:\HoaDon\HoaDonTemplate.docx";
            string folderPath = @"C:\HoaDon";
            string wordFilePath = System.IO.Path.Combine(folderPath, "HoaDon.docx");
            string pdfFilePath = System.IO.Path.Combine(folderPath, "HoaDon.pdf");

            // Kiểm tra nếu thư mục chưa tồn tại thì tạo mới
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            // Mở tệp Word mẫu
            Document document = new Document();
            document.LoadFromFile(templatePath);

            // Thay thế các placeholder trong tệp Word
            document.Replace("{Mã đơn hàng:}", lblMaDH.Text, false, true);
            document.Replace("{Ngày mua hàng:}", lblNgayMuaHang.Text, false, true);
            document.Replace("{Họ tên KH:}", lblHoTenKH.Text, false, true);
            document.Replace("{Email:}", lblEmail.Text, false, true);
            document.Replace("{Địa chỉ:}", lblDiaChi.Text, false, true);
            document.Replace("{Số điện thoại:}", lblSĐT.Text, false, true);
            document.Replace("{Tổng tiền:}", lblTongTien.Text, false, true);

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
            //MessageBox.Show($"Hóa đơn đã được xuất thành file Word tại {wordFilePath}");

            // Sau khi lưu file Word thành công, tiến hành chuyển đổi sang PDF
            try
            {
                // Sử dụng Spire.Doc để chuyển đổi từ .docx sang .pdf
                document.SaveToFile(pdfFilePath, Spire.Doc.FileFormat.PDF);
                //MessageBox.Show($"Hóa đơn đã được xuất thành file PDF tại {pdfFilePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi chuyển đổi sang PDF: {ex.Message}");
            }
        }

    }
}
