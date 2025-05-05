#

## Giới thiệu LINQ
LINQ (Language Integrated Query) - ngôn ngữ truy vấn tích hợp - nó tích hợp cú pháp truy vấn (gần giống các câu lệnh SQL) vào bên trong ngôn ngữ lập trình C#, cho nó C# khả năng truy cập các nguồn dữ liệu khác nhau (SQLDB,XML,List) với cùng cú pháp.

LINQ hoạt động trên những kiểu dữ liệu tập hợp có khả năng duyệt qua nó. Để sử dụng LINQ thì nạp hai thư viện Generic và Linq

using System.Collections.Generic;
using System.Linq;

Nguồn dữ liệu phục vụ cho LINQ, phải là các đối tượng lớp phát triển khai giao diện (interface) IEnumerable và IEnumerable<T> tức là các mảng, danh sách thuộc collection đã biết ở phần trước.

### Xây dựng lớp Product
```csharp
public class Product
{
	public int ID {get; set; }
	public string Name {get; set; }
	public double Price {get; set; }
	public string[] Colors {get; set; }
	public int Brand {get; set; }
	public Product(int id, string name, double price, string[] colors, int brand)
	{
		ID = id;
		Name = name;
		Price = price;
		Colors = colors;
		Brand = brand;
	}

	//Lay chuoi thong tin san pham
	override public string ToString()
		=>${ID,3}{Name,12}{Price,5}{Brand,2}{string.Join(",", Colors)};}

}
```

### Xây dựng lớp Brand để biểu diễn nhãn hiệu hàng hoá
```csharp
	public class Brand
	{
		public string Name {get; set; }
		public int ID {get; set; }
	}
```

### Khởi tạo ra 2 đối tượng danh sách dùng để thựuc hiện các truy vấn linq: danh sách sản phẩm ```products```, danh sách nhãn hiệu ```brands```
```csharp
var brands = new List<Brand>()
{
	new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
    new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
    new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
    new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
    new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
    new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
    new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),
}
```

### Lọc sản phẩm có giá trị có giá bằng 400
```csharp
public class Products
{
	// code

	public static void ProductPrice()
	{
		//Viet cau truy van, luu vao ket qua
		var ketqua = from p in products
				 where p.Price == 400
				 select p;
		foreach(var p in ketqua){
			Console.WriteLine(p.ToString());
		}
	}
}
```

Kết quả:
```
 ID Name          Price 
  1 Bàn trà        400    
  2 Tranh treo     400   
```

Câu lệnh truy vấn LINQ thường bắt đầu bằng mệnh đề ```from``` và kết thúc bằng lệnh ```select``` hoặc ```group```, giữa chúng là những mệnh đề ```where```, ```orderby```, ```join```,```let```

## Mệnh đề from ... in ...
Mệnh đề ```from``` để xác định nguồn dữ liệu mà truy vấn sẽ thực hiện, nguồn dữ liệu là tập hợp những phần tử lưu trong đối tượng có kiểu lớp triển khai giao diện IEnumerable như mảng Array, List, ...
```csharp
from product in products
```
- ```product``` là biến tạm thời dùng để lưu trữ từng phần tử trong tập hợp ```products```, nó có thể được đặt tên bất kỳ, nhưng thường là tên giống với tên lớp của đối tượng trong tập hợp.
- ```products``` là tên của tập hợp mà truy vấn sẽ thực hiện, nó có thể là một biến hoặc một phương thức trả về kiểu IEnumerable<T>.


## Mệnh đề select
Một câu truy vấn kết thúc bằng lệnh ```select```hoặc ```group```. Mệnh đề ```select``` chi ra các dữ liệu được lấy ra (Xuất ra) của câu lệnh LINQ.

```csharp
var ketqua = from product in products
select product;
```
Có thể trả về những đoois tượng phức tạp mà dữ liệu trích xuất ra ```from ... in ... ```
```csharp
var ketqua = from product in products
select new {
ten  = product.Name.ToUpper(),
mausac = string.Join(",", product.Colors),)
}
```

Kết quả:
- Ban tra - Xam,Xanh
- Tranh treo - Vang,Xanh


## Mệnh đề where đọc dữ liệu trong LINQ
Mệnh đề  ```where``` dùng để lọc dữ liệu
````csharp
where product.Price > 400
````

```csharp
where (product.Price >= 600 && product.Price < 700) || product.Name.StartsWith("Bàn")
```
```csharp
where product.Name.Contains("Bàn")
```

```csharp
var ketqua = from product in products
     where product.Price >= 500
     where product.Name.StartsWith("Giường")
     select product;
```

## Mệnh đề OrderBy sắp xếp kết quả trong LINQ
Để sắp xếp kết quả sử dụng ```orderby``` viết sau mệnh đề ```where``` nếu có. Mặc định sẽ sắp xếp tăng dần.

```csharp
orderby product.Price
```

Sắp xếp giảm dần
```csharp
orderby product.Price descending
```
## Mệnh đề group ... by
Cuối truy vấn có thể sử dụng group thay cho select, nếu sử dụng group thì nó trả về theo từng nhóm (Nhóm trả lại theo trường dữ liệu nào đó), mỗi phần tử của câu truy vấn trả về là kiểu ```IGrouping<TKey,IElement>```, chứa các phần tử một nhóm

```csharp
var ketqua = from product in products
where product.Price >=400 && product.Price <=500
group product by product.Price;

foreach (var group in ketqua)
{
	Console.WriteLine($"Giá: {group.Key}");
	foreach (var product in group)
	{
		Console.WriteLine(product.ToString());
	}
}
```
Có thể lưu tạm trong group trong truy vấn vào một biến bằng cách sử dụng ```into```, sau đó thi hành các mệnh đề khác trên biến tạm và dùng mệnh đề select để trả về kết quả.
```csharp
var ketqua = from product in products
where product.Price >=400 && product.Price <=500
group product by product.Price into gr
orderby gr.Key descending
select gr;
```

## let - dùng biến trong truy vấn
Dùng thêm biến vào LINQ, lưu kết quả của một biểu thức tính toán nào đó, thêm mệnh đề bằng cách viết ```let tenbien = bieu_thuc```.
```csharp
var ketqua = from product in products
group product by product.Price into gr
let count = gr.Count()
select new {
	Price = gr.Key,
	number_product = count
}
```

## Mệnh đề join - khớp nối nguồn truy vấn LINQ
```join``` là thực hiện kết hợp hai nguồn dữ liệu với nhau để truy vấn thông tin
### Inner Join
Để kết nối, dùng mệnh đề ```join``` để chỉ ra nguồn (nguồn bên phải join) sẽ kết nối nguồn của ```from``` (nguồn bên trái join), tiếp theo chỉ ra sự ràng buộc các phần tử bằng khoá ```on```

```csharp
var ketqua = from product in products
join brand in brands on product.Brand equals brand.ID
select new {
	name = Product.Name,
	brand = brand.Name,
	price = product.Price,
}
```

Phân tích truy vấn trên ta thấy

- nguồn bên trái join là : product in products
- nguồn bên phải join là : brand in brands
- liên kệ kết nối là: on product.Brand equals brand.ID (Brand trong product bằng (equals) ID của brand)

### Left Join
Trong truy vấn trên, sản phẩm nào không tìm được thông tin brand ở nguồn bên phải join thì sẽ bỏ qua. Giờ muốn sản phẩm kể cả không thấy brand cũng trả về - nghĩa nguồn bên trái lấy không phụ thuộc vào bên phải thì dùng kỹ thuật leftjoin
.
```csharp
var ketqua = from product in products
join brand in brands on product.Brand equals brand.ID into gr
from brand in gr.DefaultIfEmpty()
select new {
	name = product.Name,
	brand = brand == null ? "Không có" : brand.Name,
	price = product.Price,
}
```