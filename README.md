# Selenium Automation Cheat Sheet

## 1. METHOD TABLE / BẢNG PHƯƠNG THỨC

### English

| METHOD                | DESCRIPTION                                                                                                                                                                                                    |
| --------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| NEW CHROMEDRIVER      | CONSTRUCTS A NEW INSTANCE OF CHROMEDRIVER, WHICH IS USED TO AUTOMATE THE GOOGLE CHROME BROWSER. THIS METHOD INITIALIZES THE WEBDRIVER FOR CHROME.                                                              |
| NAVIGATED             | A METHOD OF THE IWEBDRIVER INTERFACE THAT RETURNS AN INSTANCE OF THE NAVIGATION INTERFACE, WHICH PROVIDES THE ABILITY TO NAVIGATE THROUGH BROWSER HISTORY AND TO A SPECIFIC URL.                               |
| GOTOURL(STRING URL)   | A METHOD OF THE NAVIGATION INTERFACE. IT LOADS A NEW WEB PAGE IN THE CURRENT BROWSER WINDOW WITH THE SPECIFIED URL. IN THIS CASE, IT'S USED TO NAVIGATE TO "[HTTPS://WWW.GOOGLE.COM](HTTPS://WWW.GOOGLE.COM)". |
| MANAGED               | A METHOD OF IWEBDRIVER THAT RETURNS AN INSTANCE OF THE IOPTIONS INTERFACE, PROVIDING METHODS TO MANAGE THE BROWSER.                                                                                            |
| WINDOW                | A PROPERTY OF IOPTIONS THAT RETURNS AN INSTANCE OF THE IWINDOW INTERFACE, WHICH CONTAINS METHODS FOR CONTROLLING THE SIZE AND POSITION OF THE BROWSER WINDOW.                                                  |
| MAXIMIZED             | A METHOD OF THE IWINDOW INTERFACE THAT MAXIMIZES THE BROWSER WINDOW.                                                                                                                                           |
| FINDELEMENTBY BY      | A METHOD OF IWEBDRIVER THAT FINDS THE FIRST IWEBELEMENT USING THE GIVEN METHOD. BY.NAME("Q") SPECIFIES THAT IT SHOULD FIND THE ELEMENT WITH THE NAME ATTRIBUTE EQUAL TO "Q".                                   |
| SENDKEYS(STRING TEXT) | A METHOD OF IWEBELEMENT THAT SIMULATES TYPING INTO THE ELEMENT. IT SENDS THE SPECIFIED STRING OF CHARACTERS TO THE ELEMENT. IN THIS CASE, IT'S SENDING THE TEXT "SELENIUM".                                    |
| SENDKEYS(KEYS KEY)    | ANOTHER USE OF THE SENDKEYS METHOD, BUT THIS TIME IT IS SENDING A SPECIAL KEY, THE RETURN (ENTER) KEY, TO THE ELEMENT.                                                                                         |

### Tiếng Việt

| PHƯƠNG THỨC           | MÔ TẢ                                                                                                                                                                                                            |
| --------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| NEW CHROMEDRIVER      | TẠO MỘT THỂ HIỆN MỚI CỦA CHROMEDRIVER, ĐƯỢC SỬ DỤNG ĐỂ TỰ ĐỘNG HÓA TRÌNH DUYỆT GOOGLE CHROME. PHƯƠNG THỨC NÀY KHỞI TẠO WEBDRIVER CHO CHROME.                                                                     |
| NAVIGATED             | MỘT PHƯƠNG THỨC CỦA GIAO DIỆN IWEBDRIVER TRẢ VỀ THỂ HIỆN CỦA GIAO DIỆN NAVIGATION, CHO PHÉP ĐIỀU HƯỚNG LỊCH SỬ TRÌNH DUYỆT VÀ ĐẾN URL CỤ THỂ.                                                                    |
| GOTOURL(STRING URL)   | MỘT PHƯƠNG THỨC CỦA GIAO DIỆN NAVIGATION. NÓ TẢI TRANG WEB MỚI TRONG CỬA SỔ TRÌNH DUYỆT HIỆN TẠI VỚI URL ĐƯỢC CHỈ ĐỊNH. TRONG TRƯỜNG HỢP NÀY, DÙNG ĐỂ ĐI ĐẾN "[HTTPS://WWW.GOOGLE.COM](HTTPS://WWW.GOOGLE.COM)". |
| MANAGED               | MỘT PHƯƠNG THỨC CỦA IWEBDRIVER TRẢ VỀ THỂ HIỆN CỦA GIAO DIỆN IOPTIONS, CUNG CẤP CÁC PHƯƠNG THỨC QUẢN LÝ TRÌNH DUYỆT.                                                                                             |
| WINDOW                | MỘT THUỘC TÍNH CỦA IOPTIONS TRẢ VỀ THỂ HIỆN CỦA GIAO DIỆN IWINDOW, CHỨA CÁC PHƯƠNG THỨC ĐIỀU KHIỂN KÍCH THƯỚC VÀ VỊ TRÍ CỬA SỔ TRÌNH DUYỆT.                                                                      |
| MAXIMIZED             | MỘT PHƯƠNG THỨC CỦA GIAO DIỆN IWINDOW ĐỂ PHÓNG TO CỬA SỔ TRÌNH DUYỆT.                                                                                                                                            |
| FINDELEMENTBY BY      | MỘT PHƯƠNG THỨC CỦA IWEBDRIVER ĐỂ TÌM PHẦN TỬ IWEBELEMENT ĐẦU TIÊN BẰNG PHƯƠNG THỨC ĐƯỢC CHỈ ĐỊNH. BY.NAME("Q") NGHĨA LÀ TÌM PHẦN TỬ CÓ THUỘC TÍNH NAME BẰNG "Q".                                                |
| SENDKEYS(STRING TEXT) | MỘT PHƯƠNG THỨC CỦA IWEBELEMENT ĐỂ GIẢ LẬP GÕ VÀO PHẦN TỬ. NÓ GỬI CHUỖI KÝ TỰ ĐƯỢC CHỈ ĐỊNH ĐẾN PHẦN TỬ. Ở ĐÂY, GỬI CHUỖI "SELENIUM".                                                                            |
| SENDKEYS(KEYS KEY)    | MỘT CÁCH DÙNG KHÁC CỦA PHƯƠNG THỨC SENDKEYS, NHƯNG LẦN NÀY GỬI PHÍM ĐẶC BIỆT, NHƯ PHÍM RETURN (ENTER), ĐẾN PHẦN TỬ.                                                                                              |

## 2. LOCATOR TYPE TABLE / BẢNG KIỂU ĐỊNH VỊ

### English

| LOCATOR TYPE       | DESCRIPTION                                                                                                                            |
| ------------------ | -------------------------------------------------------------------------------------------------------------------------------------- |
| By.Id              | Finds an element by its ID. This is often the most efficient and reliable way to locate elements, provided they have a unique ID.      |
| By.Name            | Locates elements by the value of their name attribute. This is useful for forms and input fields.                                      |
| By.TagName         | Finds elements based on their tag name (like div, input, span, etc.).                                                                  |
| By.ClassName       | Locates elements that have a specific class attribute. Useful for elements styled with CSS classes.                                    |
| By.CssSelector     | Uses CSS selectors for locating elements. This is a very powerful method, especially for complex and nested elements.                  |
| By.LinkText        | Finds a link (<a> tag) with the exact text specified. Useful for text-based navigation links.                                          |
| By.PartialLinkText | Locates a link (<a> tag) that contains a specific part of the text. This is useful when you only know a portion of the text in a link. |
| By.XPath           | Locates elements using XPath expressions. It's a very flexible locator and can find elements with complex and dynamic attributes.      |

### Tiếng Việt

| KIỂU ĐỊNH VỊ       | MÔ TẢ                                                                                                               |
| ------------------ | ------------------------------------------------------------------------------------------------------------------- |
| By.Id              | Tìm phần tử theo ID của nó. Đây là cách hiệu quả và đáng tin cậy nhất để định vị phần tử, nếu chúng có ID duy nhất. |
| By.Name            | Định vị phần tử theo giá trị thuộc tính name. Hữu ích cho các biểu mẫu và trường nhập liệu.                         |
| By.TagName         | Tìm phần tử dựa trên tên thẻ (như div, input, span, v.v.).                                                          |
| By.ClassName       | Định vị phần tử có thuộc tính class cụ thể. Hữu ích với các phần tử được CSS định kiểu bằng class.                  |
| By.CssSelector     | Sử dụng bộ chọn CSS để định vị phần tử. Rất mạnh mẽ, đặc biệt với phần tử lồng nhau hoặc phức tạp.                  |
| By.LinkText        | Tìm thẻ liên kết (<a>) với đúng văn bản chỉ định. Hữu ích cho liên kết điều hướng dựa trên văn bản.                 |
| By.PartialLinkText | Định vị thẻ liên kết (<a>) chứa một phần văn bản chỉ định. Hữu ích khi chỉ biết một phần văn bản trong liên kết.    |
| By.XPath           | Định vị phần tử bằng biểu thức XPath. Rất linh hoạt, có thể tìm phần tử với thuộc tính động hoặc phức tạp.          |

## 3. SELENIUM INTERACTION/ACTION METHODS / CÁC PHƯƠNG THỨC TƯƠNG TÁC/ACTION

### English

| METHOD                             | DESCRIPTION                                                                                                            |
| ---------------------------------- | ---------------------------------------------------------------------------------------------------------------------- |
| Click()                            | Simulates a mouse click on the element. Commonly used on buttons, links, checkboxes, etc.                              |
| SendKeys(string text)              | Sends a sequence of keystrokes to the element. Used for typing into text boxes, text areas, etc.                       |
| Clear()                            | Clears the text from an input field, like a text box or a text area.                                                   |
| Submit()                           | Submits a form. It's equivalent to clicking the submit button in a form.                                               |
| GetAttribute(string attributeName) | Retrieves the value of a specified attribute of the element. Useful for getting attributes like value, href, src, etc. |
| GetCssValue(string propertyName)   | Gets the value of a CSS property of the element. Useful for checking the style of an element.                          |
| IsDisplayed()                      | Checks if the element is currently displayed on the web page. Useful for validation and conditional logic.             |
| IsEnabled()                        | Determines if the element is enabled and therefore interactable.                                                       |
| IsSelected()                       | Checks if elements like checkboxes, radio buttons, or options in a select element are selected.                        |
| Text                               | Retrieves the visible (i.e., not hidden by CSS) innerText of this element, including sub-elements.                     |
| FindElement(By by)                 | Finds the first element within the current element using the given locator mechanism.                                  |
| FindElements(By by)                | Finds all elements within the current element using the given locator mechanism.                                       |

### Tiếng Việt

| PHƯƠNG THỨC                        | MÔ TẢ                                                                                                 |
| ---------------------------------- | ----------------------------------------------------------------------------------------------------- |
| Click()                            | Mô phỏng nhấp chuột vào phần tử. Thường dùng cho nút, liên kết, checkbox, v.v.                        |
| SendKeys(string text)              | Gửi một chuỗi phím vào phần tử. Dùng để nhập vào ô văn bản, textarea, v.v.                            |
| Clear()                            | Xóa văn bản khỏi trường nhập liệu, như ô văn bản hoặc textarea.                                       |
| Submit()                           | Gửi biểu mẫu. Tương đương với việc nhấn nút submit trong form.                                        |
| GetAttribute(string attributeName) | Lấy giá trị thuộc tính chỉ định của phần tử. Hữu ích để lấy các thuộc tính như value, href, src, v.v. |
| GetCssValue(string propertyName)   | Lấy giá trị thuộc tính CSS của phần tử. Hữu ích để kiểm tra kiểu dáng của phần tử.                    |
| IsDisplayed()                      | Kiểm tra phần tử có đang hiển thị trên trang web hay không. Hữu ích cho xác thực và logic điều kiện.  |
| IsEnabled()                        | Xác định phần tử có được kích hoạt và có thể tương tác không.                                         |
| IsSelected()                       | Kiểm tra các phần tử như checkbox, radio button hoặc option trong select có được chọn không.          |
| Text                               | Lấy văn bản hiển thị (không bị CSS ẩn) bên trong phần tử này, bao gồm cả phần tử con.                 |
| FindElement(By by)                 | Tìm phần tử đầu tiên trong phần tử hiện tại bằng cơ chế định vị được chỉ định.                        |
| FindElements(By by)                | Tìm tất cả phần tử trong phần tử hiện tại bằng cơ chế định vị được chỉ định.                          |

## 4. INTERACTION WITH UI ELEMENT / TƯƠNG TÁC VỚI PHẦN TỬ GIAO DIỆN

### English

To effectively perform automated User Interface (UI) testing on a webpage, the process typically involves two fundamental steps:

* **Locate a UI Element**: This step entails identifying the specific UI element you intend to interact with.
* **Execute an Action**: Once the desired UI element is successfully located, the next step is to perform the required operation on it.

### Tiếng Việt

Để kiểm thử tự động giao diện người dùng (UI) trên một trang web hiệu quả, quá trình thường gồm hai bước cơ bản:

* **Xác định phần tử giao diện**: Bước này là xác định phần tử UI cụ thể mà bạn muốn tương tác.
* **Thực hiện hành động**: Khi đã xác định thành công phần tử UI mong muốn, bước tiếp theo là thực hiện thao tác cần thiết lên nó.

## English Content

### Section: Content

#### PAGE OBJECT MODEL

Page Object is a Design Pattern that has become popular in test automation for enhancing test maintenance and reducing code duplication.

POM has other advantages such as:

* If the UI changes, only the page object code needs updating, not the tests.
* Changes in UI or locator of the app can easily be made in one place
* Distinct division between test code and page-specific code
* All services or operations offered by the page are housed in a single repository, avoiding scattering across various tests.

#### EXTENSION METHODS

Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. Extension methods are static methods, but they're called as if they were instance methods on the extended type.

#### WEBELEMENT WAIT

We know Selenium has two types of Waiting mechanism for an Element:

1. Implicit Wait
2. Explicit Wait
3. Fluent Wait

## Nội dung Tiếng Việt

### Mục: Nội dung

#### PAGE OBJECT MODEL

Page Object là một Design Pattern đã trở nên phổ biến trong tự động hóa kiểm thử nhằm nâng cao việc bảo trì kiểm thử và giảm trùng lặp mã.

POM còn có các ưu điểm khác như:

* Nếu giao diện người dùng (UI) thay đổi, chỉ cần cập nhật mã page object, không cần sửa mã kiểm thử.
* Thay đổi về UI hoặc locator của ứng dụng có thể dễ dàng thực hiện tại một nơi duy nhất
* Phân chia rõ ràng giữa mã kiểm thử và mã riêng cho từng trang
* Tất cả dịch vụ hoặc thao tác do trang cung cấp đều được lưu trữ trong một kho duy nhất, tránh việc phân tán qua nhiều kiểm thử khác nhau.

#### EXTENSION METHODS

Extension methods cho phép bạn "thêm" phương thức vào các kiểu hiện có mà không cần tạo kiểu dẫn xuất mới, biên dịch lại hoặc sửa đổi kiểu gốc. Extension methods là các phương thức tĩnh, nhưng được gọi như thể là phương thức của đối tượng trên kiểu được mở rộng.

#### WEBELEMENT WAIT

Chúng ta biết Selenium có hai cơ chế chờ cho một phần tử:

1. Chờ ngầm định (Implicit Wait)
2. Chờ tường minh (Explicit Wait)
3. Chờ linh hoạt (Fluent Wait)


✅ 1. Xác định vùng highlight bằng annotation type Highlight
csharp
Copy
Edit
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Annot;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Geom;

[Fact]
public void Pdf_ShouldCheckText_ExceptHighlightedParts()
{
    var path = "output/report.pdf";
    var textToSkip = new List<Rectangle>();

    using var reader = new PdfReader(path);
    using var pdfDoc = new PdfDocument(reader);

    // 1. Lấy vùng highlight từ tất cả các trang
    for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
    {
        var page = pdfDoc.GetPage(i);
        var annots = page.GetAnnotations();

        foreach (var annot in annots)
        {
            if (annot.GetSubtype().Equals(PdfName.Highlight))
            {
                var rect = annot.GetRectangle().ToRectangle();
                textToSkip.Add(rect);
            }
        }
    }

    // 2. Đọc toàn bộ text, nhưng bỏ qua các text nằm trong vùng highlight
    var remainingText = "";

    for (int i = 1; i <= pdfDoc.GetNumberOfPages(); i++)
    {
        var page = pdfDoc.GetPage(i);
        var strategy = new ExcludeHighlightedTextExtractionStrategy(textToSkip);
        var pageText = PdfTextExtractor.GetTextFromPage(page, strategy);

        remainingText += pageText + "\n";
    }

    // 3. Kiểm tra nội dung còn lại (đã loại bỏ phần highlight)
    Assert.Contains("Tổng doanh thu: 120,000,000 VND", remainingText);
    Assert.DoesNotContain("CHỈ DÙNG CHO KIỂM TRA", remainingText); // ví dụ đoạn được highlight
}
🧠 2. Tùy chỉnh chiến lược đọc text để bỏ qua vùng highlight
csharp
Copy
Edit
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Kernel.Pdf.Canvas.Parser.Data;
using iText.Kernel.Geom;

public class ExcludeHighlightedTextExtractionStrategy : IEventListener
{
    private readonly List<Rectangle> excludedZones;
    private readonly StringBuilder builder = new();

    public ExcludeHighlightedTextExtractionStrategy(List<Rectangle> zones)
    {
        excludedZones = zones;
    }

    public void EventOccurred(IEventData data, EventType type)
    {
        if (type != EventType.RENDER_TEXT) return;

        var textData = (TextRenderInfo)data;
        var textRect = textData.GetBaseline().GetBoundingRectangle();

        bool isInHighlight = excludedZones.Any(zone => zone.Overlaps(textRect));
        if (!isInHighlight)
        {
            builder.Append(textData.GetText());
        }
    }

    public ICollection<EventType> GetSupportedEvents() =>
        new[] { EventType.RENDER_TEXT };

    public override string ToString() => builder.ToString();
}
✅ Kết quả bạn đạt được
🟩 Toàn bộ nội dung sẽ được kiểm tra

🟨 Những đoạn có highlight (annotation kiểu "Highlight") sẽ bị bỏ qua

🧪 Đảm bảo độ chính xác cao hơn, kể cả khi PDF có vùng test động (ví dụ: thời gian, hash, hoặc comment kiểm thử)

📚 Nguồn tài liệu hướng dẫn
Stack Overflow: "Remove highlighted area in PDF using iTextSharp"
Bài viết này hướng dẫn cách xác định và xử lý các vùng được highlight trong PDF bằng cách sử dụng thông tin từ các annotation.

Stack Overflow: "Highlight specific word in a PDF document using iText7"
Bài viết này cung cấp ví dụ về cách tìm kiếm và highlight một từ cụ thể trong tài liệu PDF bằng iText 7.

Code Maze: "Create a PDF With iText in C#/.NET"
Hướng dẫn chi tiết về cách tạo và thao tác với tài liệu PDF bằng iText 7 trong C#, bao gồm cách cài đặt thư viện và viết mã để tạo PDF.

GitHub: "vniclos/itext7-C-Sharp-test-01"
Dự án mẫu trên GitHub minh họa cách sử dụng iText 7 trong C# để tạo và kiểm thử tài liệu PDF.
