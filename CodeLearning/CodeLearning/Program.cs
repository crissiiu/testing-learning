using CodeLearning.Models;
class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product() { ID = 1, Name = "Bàn làm việc", Price = 200, Colors = new[] {"Nâu", "Đen"} },
            new Product() { ID = 2, Name = "Ghế xoay", Price = 300, Colors = new[] {"Đen"} },
            new Product() { ID = 3, Name = "Bàn trà", Price = 400, Colors = new[] {"Trắng"} },
            new Product() { ID = 4, Name = "Tranh treo", Price = 400, Colors = new[] {"Trắng", "Vàng"} },
            new Product() { ID = 5, Name = "Túi da", Price = 300, Colors = new[] {"Đỏ", "Đen", "Vàng"} },
            new Product() { ID = 6, Name = "Giường ngủ", Price = 500, Colors = new[] {"Trắng"} },
            new Product() { ID = 7, Name = "Tủ áo", Price = 600, Colors = new[] {"Trắng"} }
        };

        //Cau 1: Lọc ra các sản phẩm có giá bằng 400
        var fileredProducts = products.Where(product => product.Price == 400).ToList();
        fileredProducts.ForEach(product => Console.WriteLine(product.ToString()));

        //Cau 2: Lấy danh sách tên các sản phẩm có giá lớn hơn hoặc bằng 300, sắp xếp theo giá tăng dần.
        var sortedProducts = products
            .Where(product => product.Price >= 300)
            .OrderBy(product => product.Price)
            .Select(product => product.Name).ToList();

        sortedProducts.ForEach(name => Console.WriteLine(name.ToString()));

        //Cau 3: Nhóm các sản phẩm theo giá và đếm số lượng sản phẩm trong mỗi nhóm.
        var groupedProducts = products
            .GroupBy(p => p.Price).ToList();
        Console.WriteLine($"Có {groupedProducts.Count()} nhóm sản phẩm.");
        groupedProducts.ForEach(group =>
        {
            group.ToList().ForEach(product => Console.WriteLine(product.ToString()));
        });

        //Cau 4: Lấy các sản phẩm có màu "Trắng".
        var whiteProducts = products.Where(p => p.Colors.Contains("Trắng")).ToList();
        whiteProducts.ForEach(product => Console.WriteLine(product.ToString()));

        //Cau 5: Lấy 3 sản phẩm đầu tiên có giá cao nhất.
        var top3Products = products
            .OrderByDescending(p => p.Price)
            .Take(3).ToList();

        top3Products.ForEach(product => Console.WriteLine(product.ToString()));

        //Cau 6: Kiểm tra xem có sản phẩm nào có giá dưới 200 không.
        var productPriceUnder200 = products.Any(p => p.Price < 200);

        if(productPriceUnder200)
        {
            Console.WriteLine("Có sản phẩm có giá dưới 200.");
        }
        else
        {
            Console.WriteLine("Không có sản phẩm nào có giá dưới 200.");
        }

        //Cau 7: Tạo một danh sách chỉ gồm tên sản phẩm và số lượng màu sắc của từng sản phẩm.
        var newProducts = products
            .Select(p => new { p.Name, ColorCount = p.Colors.Count() }).ToList();
        newProducts.ForEach(product =>
        {
            Console.WriteLine($"{product.Name} - {product.ColorCount} màu sắc.");
        });
    }
}