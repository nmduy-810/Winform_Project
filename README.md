# QUẢN LÝ KHÁCH SẠN
Đồ án năm 3 với chủ đề "QUẢN LÝ KHÁCH SẠN".

#1. GIỚI THIỆU

1.1 Đặt vấn đề

Trong những năm gần đây du lịch là một trong những ngành có độ tăng trưởng cao nhất cả nước. Rất nhiều khách sạn đua nhau phát triển liên tục và nhanh chóng theo sự phát triển của xã hội về qui mô và chất lượng.
Hiện nay, các khách sạn phải trực tiếp tiếp nhận, quản lý một khối lượng lớn và thường xuyên tiếp xúc nhiều loại khách, cùng với hàng loạt dịch vụ phát sinh theo nhu cầu của khách hàng. Do đó, công việc quản lý hoạt động kinh doanh của khách sạn ngày càng phức tạp hơn.
Hơn nữa, công tác quản lý không chỉ đơn thuần là quản lý về lưu lược khách đến với khách sạn, sử dụng các loại hình dịch vụ… mà công việc quản lý còn phải đáp ứng nhu cầu về việc báo cáo các loại hình doanh thu, tình hình kinh doanh của khách sạn … để từ đó có thể đưa ra định hướng và lập kế hoạch phát triển cho công việc kinh doanh đó. Nhưng với việc lưu trữ và xử lý bằng thủ công như hiện nay thì sẽ tốn rất nhiều thời gian và nhân lực mà không đem lại hiệu quả cao. Do đó cần phải tin học hóa hình thức quản lý, cụ thể là xây dựng một phần mềm để đáp ứng nhu cầu quản lý toàn diện, thống nhất và đạt hiệu quả cao nhất cho hoạt động kinh doanh của khách sạn. 
Do những nhu cầu trên nên nhóm chúng em quyết định chọn đề tài thực tập cuối khóa là “Quản lý khách sạn” như là một chính yếu cho nhu cầu ứng dụng công nghệ thông tin vào kinh doanh.

1.2 Mục tiêu của đề tài

Tìm hiểu cơ cấu tổ chức và cách hoạt động của khách sạn.
		- Tìm hiểu nhiệm vụ và qui trình  thực hiện công việc tại khách sạn.
		- Khảo sát tình hình thực tế của khách sạn.
- Áp dụng các kiến thức về Cơ sở dữ liệu và Phân tích - thiết kế hệ thống thông tin quản lý để xây dựng chương trình quản lý Khách sạn tự động thực hiện một số công việc bằng máy tính có thể thay thế một phần công việc cho con người.

Dựa vào những kiến thức học được từ môn Phân tích Thiết Kế Hệ Thống Thông Tin, đồ án sẽ này sẽ phân tích thiết kế hệ thống quản lý khách sạn nhằm mục đích tạo một hệ thống quản lý việckinh doanh một khách sạn bao gồm các chức năng:

- Quản lý nhân sự.
- Quản lý danh mục hệ thống (phòng ở, trang thiết bị, dịch vụ, đơn giá,…).
- Quản lý khai thác sử dụng (đặt phòng và sử dụng các dịch vụ).
- Quản lý khách hàng.
- Quản lý doanh thu.
- Quản lý hóa đơn.

#2. NGHIỆP VỤ

2.1 Quy trình đặt phòng :

Khách sạn quản lý những thông tin sau: Số nhận phòng, họ tên người nhận phòng, ngày nhận, giờ nhận. 
Tất cả thông tin nhận phòng đều dựa vào thông tin đăng ký thuê phòng đã khai báo trước đó. Vì khách hàng có đăng ký mới được nhận phòng theo đúng thông tin mà khách đã đăng ký.
2.2 Quy trình trả phòng

Dựa trên thông tin đăng ký thuê phòng và thông tin nhận phòng, việc trả phòng được khách sạn quản lý các thông tin sau: Số trả phòng, ngày trả, giờ trả, họ tên người trả (có thể trả phòng trước thời hạn đăng ký). 
Nếu khách hàng muốn gia hạn thêm thời gian ở tại khách sạn thì phải tiến hành làm thủ tục đăng ký lại. Bên cạnh việc trả phòng của khách thì khách sạn sẽ kiểm tra lại tình trạng phòng.

2.3 Quy trình quản lý khách hàng :

Mỗi khách hàng của khách sạn đều được khách sạn quản lý những thông tin sau: Họ tên, giới tính, địa chỉ, điện thoại (nếu có), E_mail(nếu có), số CMND (hoặc các văn bằng khác có hình), quốc tịch. 

2.4 Quy trình quản lý phòng :

Các phòng của khách sạn được quản lý dựa vào phòng số, loại phòng, giá cơ bản. 
Khách sạn gồm có ba loại phòng 1, 2, 3 tương ứng với giá như sau 150.000đ, 200.000đ, 250.000đ (trong đó có 10% VAT). Ngoài ra mỗi phòng còn được trang bị dịch vụ nên dịch vụ cũng được quản lý theo mã dịch vụ, tên dịch vụ. 
2.6 Quy trình quản lý đăng ký phòng :

Tất cả các thông tin đăng ký thuê phòng đều được quản lý dựa trên mã đăng ký, họ tên khách đăng ký, ngày đến, giờ đến, ngày đi, giờ đi, số lượng người lớn, số lượng trẻ em và số tiền đặt cọc. 

2.5 Quy trình quản lý nhân viên phục vụ :

Tất cả những nhân viên làm việc tại khách sạn đều được quản lý các thông tin sau: Mã số nhân viên, Họ nhân viên, Tên nhân viên, Chức vụ của nhân viên.
Ngoài ra khách sạn còn quản lý thông tin về dịch vụ:  tên dịch vụ; tiện nghi. Tại khách sạn có nhiều loại dịch vụ như: điện thoại, ăn uống, giặt ủi, đưa đón khách, chuyên chở đồ cho khách (khi khách yêu cầu)...

2.6 Quy trình quản lý hóa đơn :

Khi khách thanh toán tiền phòng, hóa đơn sẽ ghi lại mọi chi phí sinh hoạt cũng như dịch vụ khách sử dụng dựa vào mã hóa đơn, tên hóa đơn, các dịch vụ khách hàng dùng, chi phí phát sinh và trước đó nếu khách hàng có sử dụng đặt cọc trước để giữ phòng.

