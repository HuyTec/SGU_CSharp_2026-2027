# Bài tập 1: 
Xây dựng một ứng dụng Console cơ bản quản lý danh sách các cuốn sách, mỗi cuốn
sách này chứa các thông tin như sau: tên sách, tên tác giả, nhà xuất bản, năm xuất bản, số hiệu
ISBN (International Standard Book Number) và danh mục các chương sách (chỉ chứa tên chương).
Thực hiện theo các yêu cầu sau:
- Xây dựng một interface có tên là IBook, mô tả property và method cần thiết cho các lớp
dạng Book thực thi.
- Xây dựng lớp Book kế thừa từ IBook, thực hiện các mô tả trong IBook và các chi tiết riêng
của Book.
- Xây dựng lớp BookList quản lý danh sách các đối tượng Book, lớp này chứa các thao tác
trên danh sách các đối tượng Book.
- Thực thi giao diện IComparable, định nghĩa quan hệ thứ tự trong phương thức
CompareTo...
- Sử dụng giao diện IComparer, hỗ trợ sắp xếp theo nhiều tiêu chuẩn khác nhau...
- Viết hàm Main thực thi yêu cầu sau:
    - Cho nhập vào một mảng chứa những cuốn sách.
    - Xuất danh sách thông tin những cuốn sách.
    - Lần lượt xuất danh sách ra theo thứ tự được sắp theo tên tác giả, tên sách, năm xuất
bản.

# Bài tập 2:
Bổ sung chức năng hỗ trợ để sắp xếp danh sách book theo một thứ tự nào đó, ví dụ sắp danh
sách theo thứ tự alphabet của title, thứ tự theo author, thứ tự theo publisher, thứ tự theo năm...
Có 2 cách thực hiện:
- Thực thi giao diện IComparable
- Sử dụng giao diện IComparer, tạo các lớp hỗ trợ sắp xếp theo các tiêu chuẩn khác nhau

# Bài tập 3:
- Tạo một lớp Account chứa các thông tin tài khoản ngân hàng như sau:
    - Account ID: mã số tài khoản
    - First Name
    - Last Name
    - Balance: số dư tài khoản
- Viết các phương thức constructor, phương thức hiển thị thông tin tài khoản, phương thức
nhập thông tin tài khoản (từ bàn phím).
- Tạo lớp AccountList chứa danh sách các Account, sử dụng ArrayList để lưu trữ danh
sách này. Viết các phương thức sau
    - NewAccount: thêm một account mới vào danh sách
    - SaveFile: lưu danh sách account vào file
    - LoadFile: lấy danh sách account từ file vào danh sách
    - Report: xuất ra màn hình tất cả danh sách các account

# Bài tập 4:
- Bổ sung thêm chức năng Remove xóa một account ra khỏi danh sách. Sử dụng
BinarySearch của ArrayList để xác định chỉ mục của đối tượng có khóa nào đó, theo tiêu
chí so sánh trong các lớp IComparer được xây dựng hỗ trợ cho Account.
- Sắp xếp danh sách theo thứ tự tăng dần của Account ID, First Name, Balance.
- Sinh viên tìm hiểu Serialization và sử dụng để lưu trữ các đối tượng account thay thế cho
File I/O cơ bản bên trên.