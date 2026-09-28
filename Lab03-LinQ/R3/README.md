# .NET Nâng cao - Bài tập minh họa

## Bài 03: Thiết kế hướng đối tượng

**Giảng viên:** Đỗ Như Tài  
**Lưu ý:** Bài 3 và Bài 4 là phần tự làm.

---

## Bài 1: Tính tiền thuê phòng khách sạn

Viết chương trình tính tiền thuê phòng khách sạn.

Một phiếu thuê phòng gồm:

- Họ tên khách hàng
- Ngày bắt đầu
- Ngày kết thúc
- Loại phòng thuê

Khách sạn có 3 loại phòng:

| Loại phòng | Đơn giá/ngày |
|---|---:|
| A | 220.000 Đ |
| B | 200.000 Đ |
| C | 170.000 Đ |

Nếu thuê trên 6 ngày, khách hàng được giảm 10% tiền thuê.

---

## Bài 2: Quản lý lương nhân viên công ty X

Viết chương trình quản lý thông tin cần thiết để tính lương nhân viên công ty X. Nhân viên thuộc một trong hai bộ phận với cách tính lương khác nhau.

### Bộ phận văn phòng

- Hưởng lương thời gian.
- Mỗi nhân viên có mức lương tháng riêng.
- Nếu vắng quá 3 ngày, mỗi ngày vắng trong tháng bị trừ 100.000 Đ/ngày.

### Bộ phận sản xuất

- Hưởng lương sản phẩm.
- Lương tháng phụ thuộc vào số lượng sản phẩm và đơn giá sản phẩm thực hiện trong tháng.
- Nếu số sản phẩm vượt quá 1.200, nhân viên được thưởng thêm 5% lương.

---

## Bài 3: Tính tiền hóa đơn bán hàng (tự làm)

Viết chương trình tính tiền hóa đơn bán hàng của một công ty.

Một hóa đơn gồm:

- Họ tên khách hàng
- Tên mặt hàng thanh toán
- Số lượng

Giả sử mỗi hóa đơn chỉ thanh toán cho một mặt hàng.

Công ty chỉ bán 4 loại mặt hàng:

| Loại mặt hàng | Đơn giá/mặt hàng |
|---|---:|
| X | 1.200.000 Đ |
| Y | 2.500.000 Đ |
| Z | 570.000 Đ |
| T | 1.870.000 Đ |

Nếu một mặt hàng được mua với số lượng trên 5, giảm 8% tiền của mặt hàng đó.

---

## Bài 4: Tính tiền hóa đơn dịch vụ khách sạn X (tự làm)

Viết chương trình quản lý thông tin cần thiết để tính tiền hóa đơn sử dụng dịch vụ của khách sạn X. Tính và xuất số tiền khách hàng phải trả.

Khách sạn X có 2 loại dịch vụ với hai cách tính tiền khác nhau.

### Dịch vụ thuê xe

- Tiền thuê xe = số giờ thuê × đơn giá/giờ của loại xe thuê.
- Nếu thuê quá 6 giờ, giảm 5% tiền thuê.

### Dịch vụ điện thoại

- Tiền sử dụng điện thoại = số phút gọi × đơn giá/phút của loại cuộc gọi.
- Nếu tổng tiền gọi vượt quá 500.000 Đ, giảm 10%.
