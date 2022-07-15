FirstProgram C#
<h2>CourseIntroduction</h2>
Mục tiêu khoá học:
C# features<br>
•	.NET Framework là programing framework cho phép chúng ta xây dựng và triển khai ứng dụng được viết bằng .NET<br>
•	Sử dụng .NET Framework có thể giảm thiểu thời gian để viết và triển khai ứng dụng phần mềm<br>
•	.NET Framework có 2 phần chính<br>
-	Common language runtime(CLR): được gọi là execution engine chạy trên c#<br>
-	Framework class library(FCL): là một thư viện của class, interface, value type cho phép tương tác với hệ thống. VD:system.io<br>
•	C# codeSnippet là đoạn code dựng sẵn, bạn có thể quickly insert vào trong source code<br>
<h2>1 6 Nuget</h2>
Nuget là cơ chế cho phép lập trình viên có thể tạo, chia sẻ library hữu ích, những library này được gọi là packages
![image](https://user-images.githubusercontent.com/94780400/179254710-a2a093f6-709c-4a1f-842e-47984c219f1c.png)
1 7 HelloWorld

•	Hàm main sẽ nhận input là một mảng của các string và trả lại giá trị void
      Console.WriteLine("Hello World!"); //in ra màn hình
         Console.ReadKey();// để dừng màn hình
1 8 BuildingPart1
•	Building có thể giúp các bạn phát hiện ra lỗi trong quá trình compile-time và quá trình run-time. Trong quá trình compile-time thì chúng ta có thể phát hiện ra lỗi sai về cú pháp, sai về keyword, typematch, còn trong quá trình run-time thì việc building sẽ cho phép chúng ta phát hiện ra lỗi về logic hoặc lỗi về ngữ nghĩa(sematic errors)
•	Phương pháp build
 ![image](https://user-images.githubusercontent.com/94780400/179254832-6e812010-7cec-4319-9d54-e7417ddbd4e9.png)
2 3 Assembly And Exe
•	Assembly theo định nghĩa của Microsoft thì nó sẽ hình thành ra một đơn vị cơ quản của deployment, hoặc có thể hiểu Assembly là .NET code đã được precompiled và có thể chạy trên CLR
•	File exe chỉ là 1 dạng của .NET assembly
![image](https://user-images.githubusercontent.com/94780400/179254900-b045dd22-bdbf-4399-9b39-192b9f6322ae.png)
2 4 DLL
•	DLL(Dynamic Link Library) là một thư viện có thể chứa code và data được sử dụng bởi 1 hoặc nhiều chương trình tại cùng 1 thời điểm
![image](https://user-images.githubusercontent.com/94780400/179254952-9de24997-ce58-4bef-a835-bd2ba146b3b4.png)
4 1 Identifiers
•	Identifiers là thành phần định danh, là tên để đặt cho class, variable, function hoặc bất cứ item nào chúng ta định nghĩa ra
•	Trong C# đặt tên thì nên tuân theo luật sau
-	Tên đặt phải bắt đầu bằng 1 ký tự hoặc dấu gạch dưới_ hoặc dấu @
-	Trong tên không được chứa khoảng trắng, ký tự đặc biệt như ?,-,+!
-	Tên đặt ra không được trùng với keyword
-	Identifiers C# là case-sensitive là phân biệt thường và viết hoa.
![image](https://user-images.githubusercontent.com/94780400/179254988-64c44e24-7b15-4976-9f4a-c467d8a1dae7.png)
4 3 Keywords
•	Keywords: Từ khoá cũng giống identifiers, đều là những thành phần cơ bản của mọi ngôn ngữ lập trình, từ khoá là tập hợp cũng những từ mà ngôn ngữ lập trình dành sẵn và có ý nghĩa đặc biệt trong 1 chương trình.
•	 Ý nghĩa của các từ khoá không thể thay đổi và chúng ta không thể sử dụng từ khoá 1 cách trực tiếp như Identifiers trong 1 chương trình. Tuy nhiên nếu muốn sử dụng từ khoá trong 1 chương trình ta sẽ phải chỉ định @trước từ khoá đó
Danh sách từ khoá
![image](https://user-images.githubusercontent.com/94780400/179255028-3902261a-6b8b-4db9-bb68-4a64fc237820.png)
![image](https://user-images.githubusercontent.com/94780400/179255034-cc00fe7d-e769-4e14-b461-910c37b59e1c.png)
4 5 NamingConvention
•	Quy ước đặt tên là tập hợp các rules do chúng ta đề ra để chọn Identifiers hoặc những thực thể trong source code hoặc trong documentation
•	Lợi ích của quy ước đặt tên là:
-	Làm giả được những effort cần thiết để đọc và hiểu code của mọi người trong 1 dự án, tối ưu và giảm thời gian đọc code của chính mình
-	Cho phép tool review code tự động, có thể tập trung vào vấn đề quan trọng của source code hay documentation
![image](https://user-images.githubusercontent.com/94780400/179255058-e5f4c29d-eb59-4b72-8cbc-3428bda20332.png)
•	Sủ dụng PascalCasing: là viết hoa chữ cái đầu tiên của mỗi từ cho class và method
•	camelCasing: dùng cho method arguments và local variables
![image](https://user-images.githubusercontent.com/94780400/179255089-4d385db2-6e03-43d1-a04a-22cf0b8edebb.png)
![image](https://user-images.githubusercontent.com/94780400/179255125-b8e6d1a4-1a5a-4769-9c4b-3510438e19e8.png)
•	không sử dụng Screaming Caps cho biến constants hoặc biến readonly (không viết hoa toàn bộ biến)
![image](https://user-images.githubusercontent.com/94780400/179255192-273ca4a9-8072-4771-bf54-c2b7c13e6c53.png)
•	tránh việc viết tắt tên biến
![image](https://user-images.githubusercontent.com/94780400/179255252-47308a35-b200-4555-ae60-9e58cfaec52f.png)
•	sử dụng PascalCasing cho viết tắt có nhiều hơn 3 ký tự và sẽ sử dụng uppercase đối với biến có 2 kí 
![image](https://user-images.githubusercontent.com/94780400/179255296-03674da4-ac97-4ec4-a708-bba392718e37.png)
•	không sử dụng Underscores trong identifiers. 
•	Nhưng trong private có thể sử dụng Underscores( VD: private Datetime _registrationDate;)
![image](https://user-images.githubusercontent.com/94780400/179255332-3d6c11df-527a-4c84-9028-b8e799aea275.png)
•	Sử dụng implicit type var cho biến local, không nên dùng cho biến kiểu primitive như int,string,double
![image](https://user-images.githubusercontent.com/94780400/179255369-2f537516-4aee-4cdb-ad1c-d2320c0518ea.png)
•	Nên sử dụng chữ I viết hoa trước interface 
![image](https://user-images.githubusercontent.com/94780400/179255409-7c068373-46d4-4910-8c51-39e0a6dfa26e.png)
•	Sử dụng vertically align curly brackets: align dấu mở đóng ngoặc trên cùng 1 dòng {} 
![image](https://user-images.githubusercontent.com/94780400/179255463-a9b094b3-d308-414c-870e-1002de6d2b81.png)
•	Nên khai báo tất cả biến variable, properties trong 1 class lên trên đầu sau đó mới đến method
![image](https://user-images.githubusercontent.com/94780400/179255515-6dfbbc98-abfc-489e-a5a6-68f12c488ceb.png)
•	Nên sử dụng tên của enums ở dạng singular số ít
![image](https://user-images.githubusercontent.com/94780400/179255551-976725b3-767c-49fe-931f-75e444badbf0.png)
•	Không sử dụng suffix cho enum

![image](https://user-images.githubusercontent.com/94780400/179255595-af4bb5f4-bf01-4d8b-94a9-52186b16bf4f.png)
4 7 DataType
•	Data type: là phân loại kiểu dữ liệu và mục đích sử dụng cho từng loại và chia dữ liệu dưới dạng số, dạng chuỗi, thời gian
•	C# có 2 categories của data type đó là:
-	Vule type: lưu những biến sử dụng dưới dạng value type và trỏ trực tiếp tới vùng nhớ của giá trị được gán tới nó
![image](https://user-images.githubusercontent.com/94780400/179255671-32c466f5-d43d-41cb-a264-fa988ba46675.png)
có 2 loại
	Predefined data type: kiểu int, Boolean, float
	User defined data type: kiểu enum
![image](https://user-images.githubusercontent.com/94780400/179255712-11039a3e-bbbf-4963-8e52-e7f1bbfd831f.png)
-	Reference type: ngược lại với value type là những biến được gán giá trị thì nó sẽ không trỏ trực tiếp tới vùng nhớ của giá trị mà sẽ chỉ chứa con trỏ và con trỏ sẽ trỏ tới vùng nhớ đó. Có nghĩa là biến sử dụng reference type thì nó sẽ chứa con trỏ và trỏ tới giá trị thực.
![image](https://user-images.githubusercontent.com/94780400/179255743-7a1e7e35-8f75-40a6-8715-a53abbadac3b.png)
-	có 2 loại
	Object string
	Class interface
![image](https://user-images.githubusercontent.com/94780400/179255796-1667afdc-61cb-4571-b847-2ecb803c7615.png)
4 9 Variable
•	Bản thân data có 2 kiểu:
-	Dữ liệu cố định hay còn gọi là const hoặc fix value(dữ liệu ko thay đổi)
-	Variable value chính là tên mà chúng ta gọi ra trong data value
•	Có 2 kiểu khai báo biến
![image](https://user-images.githubusercontent.com/94780400/179256121-1eba9193-fd6a-4464-9796-580f69d1378a.png)
![image](https://user-images.githubusercontent.com/94780400/179256138-c24316f6-8248-4aaa-b98a-d806ca684ddd.png)
4 10 VariableInitialization
•	Khởi tạo biến trong C#
-	Có thể khai báo biến sử dụng theo 2 cú pháp như sau
![image](https://user-images.githubusercontent.com/94780400/179256226-7df6960f-53ac-408e-8763-49bc06125288.png)
•	Giá trị mặc định của references type là null
![image](https://user-images.githubusercontent.com/94780400/179256253-5e5e6e4c-e823-4e72-a93f-ab63efcacfab.png)
3 17 VariableScopeVideo
•	Phạm(scope) vi của biến(Variable) trong C# là area hoặc region của code mà ở đó chúng ta có thể accept và sử dụng biến đó
•	Trong C# có 3 level scope:
-	Class-level scope: những biến được định nghĩa trong 1 class thì nó sẽ available cho tất cả method trong class đấy
![image](https://user-images.githubusercontent.com/94780400/179256328-2ffb383b-1eb7-4ddc-9987-c06aa6386122.png)
-	Method-level scope: những biến được khai báo trong method thì nó sẽ available cho tất cả thành phần còn lại trong method đó
![image](https://user-images.githubusercontent.com/94780400/179257842-f9574ff9-a1c9-45f9-a534-b71e92bf3080.png)
-	Nested scope : những biến được định nghĩa trong vòng lặp for, while, do-while, loop.v.v thì những biến này sẽ chỉ available trong vòng lặp này và chỉ được accept bởi vòng lặp này. Ở bên ngoài vòng lặp thì sẽ không sử dụng nó, những biến này được gọi là local variables
4 12 VarDynamic
•	Kiểu ngầm định cho local variables trong C#
•	Local variables là những biến được khai báo và sử dụng trong method, ngoài ra không được sử dụng ở chỗ khác. Khi khai báo 1 biến thì cần chỉ định data type cho biến đó, tuy nhiên C# cho phép dùng từ khoá var để k![image](https://user-images.githubusercontent.com/94780400/179258032-fe9e46a9-3716-40e9-819e-6845bc90a3f9.png)
![image](https://user-images.githubusercontent.com/94780400/179257891-a40b1fde-e85d-488c-aa07-4063ba13b631.png)
•	Chú ý khi sử dụng var
-	Var có thể sử dụng khi biến local variable được khai báo và khởi tạo trong cùng 1 câu lệnh
-	Var không thể dùng để khai báo cho fields trong phạm vi class
-	Không thể sử dụng var để khai báo multiple implicitly-typed
-	Trong hầu hết var được coi là optional và chỉ coi là syntactic(viết cho tiện và nhanh)
•	Dynamic không thực hiện việc check kiểu dữ liệu của variable tại thời điểm compile-time mà sẽ chỉ xác định kiểu của biến tại thời điểm runtime 
![image](https://user-images.githubusercontent.com/94780400/179258306-f34a93f3-0835-4e6c-b31b-d7acd962ed44.png)
4 14 StackAndHeap
•	Khi khai báo biến variable trong C# thì .NET Framework sẽ allocates vùng nhớ trên ram
•	Có 2 loại vùng nhớ: stack và heap
-	Stack : là vùng nhớ trên ram và hoạt động theo cơ chế LIFO(Last in, First out). Mỗi lần khai báo biến thì nó sẽ tự động push vào trong stack, sau đó khi biến fall out scope và function kết thúc thì biến sẽ allocates khỏi stack
-	Heap: là vùng nhớ trên ram tuy nhiên cho phép allocates vùng nhớ 1 cách tự động và sẽ không hoạt động theo cơ chế của stack(LIFO). Ta sẽ tương tác với heap thông qua con trỏ và con trỏ này sẽ chỉ tới vùng nhớ trên heap
hai báo biến mà không cần phải chỉ ra tường minh data type cho biến đó. 
![image](https://user-images.githubusercontent.com/94780400/179258320-4815faf1-6955-41ae-be55-9583153fdc89.png)
![image](https://user-images.githubusercontent.com/94780400/179258408-4f3326c4-a676-46e1-bcc6-4db8f64e801f.png)
•	Khi một function kết thúc thì stack sẽ tự động empty còn heap thì nó vẫn chứa dữ liệu
•	Đặc điểm của stack 
-	Hoạt động nhanh
-	Không cần phải explicitly de-allocate biến
-	Quản lý bởi CPU nên ram sẽ không bị phân mảnh
•	Đặc điểm của Heap
-	Không giới hạn về kích thước bộ nhớ
-	Hoạt động chậm hơn stack
-	Bộ nhớ heap sẽ bị fragmented theo thời gian
OutvsRefVideo
•	Về cơ bản out và ref sẽ cho phép chúng ta pass 1 biến dạng references với một method 
•	Khác biệt giữa ref và out 
-	Ref không cần khởi tạo giá trị khi truyền vào
-	Out cần khởi tạo giá trị cho method
4 15 BoxingUnboxing
•	Boxing là quá trình convert value type trở thành data type object(data type obj là references type). Khi CLR command language runtime boxes wraps giá trị đó vào trong system.obj sau đó lưu giá trị đó lên heap
•	Unboxing thì ngược lại thì nó sẽ extracts value type từ obj
•	Boxing là ngầm định, unboxing thì là tường minh. 
![image](https://user-images.githubusercontent.com/94780400/179258417-ef1fe5c8-b78e-48bb-9915-ccb0aab3f5a5.png)
![image](https://user-images.githubusercontent.com/94780400/179258461-73eee717-06a4-4d3c-bb4a-d6ed4b432959.png)
•	Lợi ích của boxing và unboxing :
-	 Cho phép chúng ta có một cái nhìn thống nhất về data type của C#, chúng ta có thể treated value giống references type
-	Boxing có thể đẩy kiểu int vào trong collection array list
4 16 GarbageCollection
•	Mỗi lần khai báo biến trong C# thì tự động .NET Framework đẩy biến vào trong stack, với value type thì nó trỏ trực tiếp vào giá trị, còn giá trị của references type được lưu trên heap. Biến trên stack trỏ đến vùng nhớ trên heap
•	Stack và heap đều là bộ nhớ trên ram và ram thì không phải vô tận, chính vì vậy nếu chúng ta khai báo quá nhiều ref type thì heap sẽ tăng size đến giới hạn ram và chương trình sẽ không chạy
•	.NET Framework có .NET garbage  collector sẽ quản lý vùng nhớ cho chúng ta/ Garbage collector sẽ làm nhiệm vụ cấp phát và giải phóng bộ nhớ cho ứng dụng
-	Mỗi lần tạo object thì CLR sẽ allocate bộ nhớ cho obj để quản lý trên heap
-	Check obj trên heap có còn được sử dụng hay không , sau một thời gian dài mà không được sử dụng thì nó sẽ xoá 
•	Garbage collector sẽ xử dụng khái niệm generation có nghĩa là vùng nhớ heap sẽ được chia thành các vùng generation long-live và short-lived object(obj có vòng đời dài và ngắn)
-	Generation 0: gọi là youngest generation và nó chỉ chứa obj có vòng đời ngắn. Ví dụ về short-lived obj là các biến temporary, chúng ta có một function và khai báo những biến trong function đó sẽ gọi là temporary variable
-	Generation 1: chứa short-lived obj và nó hoạt động giống như buffer giữa short và long-lived obj. Những obj sống sót quau generation 1 thì sẽ chuyển qua generation 2
-	Generation 2 : chỉ chứa long-lived obj(obj có vòng đời dài) và đây là generation cuối
•	Lợi ích của garbage collector
-	Không cần lo lắng về cấp phát vùng nhớ và lấy lại vùng nhớ, chỉ đơn giản viết ra obj thì tự động garbage collector sẽ dọn dẹp vùng nhớ cho chúng ta và chỉ cần tập trung vào nghiệp vụ
-	Garbage collector sử dụng series thuật toán để allocated và lưu một cách tốt nhất.
 6 0 Introduction Video
•	Operators: toán tử , kí hiệu để thực thi hoạt động trên những toán hạng. Các toán hạng có thể là biến, có thể là const
•	Ví dụ: 2+3 thì 2 và 3 là toán hạng còn + là toán tử
![image](https://user-images.githubusercontent.com/94780400/179258486-767a3cb2-c1e4-490d-8cfb-26d0b7e67bf5.png)
6 1 Arimethic Video
Toán tử toán học được sử dụng để thực thi những hoạt động toán học giữa những toán hạng khác nhau. Những hoạt đồng này bao gồm +-*/ 
![image](https://user-images.githubusercontent.com/94780400/179258509-4ae33b89-2c2e-4b76-8159-05013cef6454.png)
6 2 Assigment Video
•	Assigment operator: toán tử gán sẽ gán giá trị từ toán hạng bên tay phải sang toán hạng bên tay trái 
•	Toán tử = sẽ gán giá trị từ toán hạng bên phải sang bên trái ví dụ : C = A + B thì lúc này nó sẽ gán A + B cho C
•	Toán tử += nó sẽ cộng toán hạng bên trái và bên phải ra giá trị bao nhiêu thì nó sẽ gán lại vào trong toán hạng bên trái. Ví dụ: C+= A thì nó sẽ + C với A ra giá trị bao nhiêu thì nó sẽ gán lại vào C
•	Toán tử -= ngược lại với += thì nó sẽ trừ toán hạng bên trái cho bên phải sau đó được giá trị bao nhiêu thì sẽ gán ngược lại bên trái. Ví dụ C -= A thì nó sẽ ngược lại C – A bằng bao nhiêu thì gán cho C
•	Toán tử *= sẽ nhân 2 toán hạng với nhau và so sánh
•	Toán tử /= lấy phần dư của toán hạng bên trái và chia cho bên phải được bao nhiêu thì gán lại vào bên trái
![image](https://user-images.githubusercontent.com/94780400/179258552-207b592f-8a44-4219-90c9-421bccf9a0a3.png)
6 3 Conditional Video
•	Conditional operator trong C# được kí hiệu là (?:) và nó sẽ trả lại 1 trong 2 giá trị phụ thuộc vào biểu thức boolean 
•	Cú pháp như sau:
![image](https://user-images.githubusercontent.com/94780400/179258692-98f2a4f3-fe0d-47f7-9bfa-cfee724b593f.png)
-	Đầu tiên có biểu thức điều kiện(condition), khi mà condition là true thì nó sẽ trả về first_expression còn nếu trả về false thì sẽ trả về second_expression
-	Lưu ý là first_expression và second_expression đều phải cũng kiểu dữ liệu hoặc ngầm định convert giữa 2 loại
6 4 Comparison Video
•	So sánh trong C# có 2 loại:
-	So sánh bằng(value equality) sẽ quyết định xem là giá trị chứa trong 2 biến có bằng nhau hay không
-	So sánh bằng thứ 2 là reference equality nó sẽ quyết định xem 2 biến nó có trỏ đến 1 vùng nhớ hay không
•	Về reference Equality chúng  ta có thể sử dụng phương thức gọi là object.ReferenceEquals và phương thức này trả về true hoặc false
-	True có nghĩa là 2 biến cùng trỏ tới 1 vùng nhớ
-	False 2 biến trỏ tới 2 vùng nhớ khác nhau 
![image](https://user-images.githubusercontent.com/94780400/179258735-df12cfc7-c8e5-46b7-8dcd-cc5fce8c9602.png)
•	Value Equality
![image](https://user-images.githubusercontent.com/94780400/179258781-4a18de1b-2683-4443-8566-847545bf89eb.png)
6 5 Logical Video
•	Toán tử Logic thực thi hoạt động logic giữa những biến với nhau, hoạt động logic bao gồm and,or và nó sẽ trả lại giá trị true,false. Những toán tử logic này hay được sử dụng khi chúng ta sử dụng decision making if else và sử dụng loop
-	Toán tử and có kí hiệu &&: nó sẽ chỉ trả lại giá trị true khi 2 toán hạng đều là true
-	Toán tử or kí hiệu ||: toán tử này sẽ chỉ trả về true nếu 1 trong 2 toán hạng là true
-	Toán tử not kí hiệu !: 
8 1 IFElse Video
•	Trong C# if là câu lệnh điều kiện có nghĩa là nếu biểu thức trong câu lệnh if đúng thì chúng ta sẽ thực thi 1 số câu lệnh. Còn trong trường hợp else thì chúng ta sẽ thi một số câu lệnh khác
•	Trong C# có thể follow bởi 0 hoặc 1 câu lệnh else(optional: có thể có hoặc không)
![image](https://user-images.githubusercontent.com/94780400/179258820-148a6540-1e4b-4414-b2ae-f66844e431f8.png)
•	Expression: biểu thức là thứ gì đấy trả lại giá trị
•	Statement là những đoạn code để làm một việc gì đấy sẽ không trả lại giá trị 
•	Else if…else Statement 
-	Else if luôn đứng sau if và đứng trước else
![image](https://user-images.githubusercontent.com/94780400/179258851-ba98f09a-3b25-4b5a-8af8-1ddc437565d3.png)
•	Nested if Statement: Tức là sử dụng if else lồng nhau trong C#, có nghĩa chúng ta có thể sử dụng câu lệnh if else nằm trong câu lệnh if else khác
![image](https://user-images.githubusercontent.com/94780400/179258876-700a95da-94bb-4777-9dc0-3887e6ab66df.png)
8 3 Switch1Video
•	Constant pattern: một lệnh switch có thể cho phép chúng ta so sánh một biến với một danh sách các giá trị và mỗi giá trị này gọi là một case(trường hợp)
![image](https://user-images.githubusercontent.com/94780400/179258900-338a7d53-bff0-470e-964b-855daf49aca0.png)
•	Lưu ý expression ở đây là enum hoặc kiểu số
•	Break: dừng điều kiện khi đã thoả mãn và thoát ra(optional)
8 5 SwitchNewVideo
•	Constant pattern: giá trị trong case luôn là dạng số hoặc enum 
![image](https://user-images.githubusercontent.com/94780400/179258924-ed037e52-8eeb-4178-a939-ff2211db1390.png)
Viết gọn hơn với new Approach trong C#:
![image](https://user-images.githubusercontent.com/94780400/179258952-e95dfbee-25b4-4237-b406-c021bcd46072.png)
•	Type pattern: trong swich thì expression luôn phải là dạng số hoặc enum
![image](https://user-images.githubusercontent.com/94780400/179258995-c78d044a-03fd-42ba-ab76-5899f87f6fc9.png)
8 7 ForLoopVideo
•	Trong C# có thể dùng câu lệnh for để chạy khối lệnh lặp đi lặp lại cho đến khi một expression bị đánh giá là false hoặc chúng ta tường minh thoát ra khỏi vòng for đó
•	Cú pháp
![image](https://user-images.githubusercontent.com/94780400/179259028-34f4fccf-f181-466a-812a-2f6565826e07.png)
Trong đó: 
-	init cho phép chúng ta có thể khai báo và khởi tạo biến để control và kiểm soát vòng lặp, init có thể là optional(dùng hoặc không)
-	condition: trả về true hoặc false. Trong trường hợp trả về true thì nó sẽ thực thi khối lệnh trong phần thân lệnh for và sau khi thực thi xong thì nó sẽ chạy đến increment(tăng giá trị của biến điều khiển vòng loop này lên và sau đó nó đánh giá lại condition, trong trường hợp condition trả về true thì sẽ tiếp tục chạy, còn nếu false thì nó sẽ interminate)(increment là optional)
-	dừng vòng for dùng break;
•	trong C# sử dụng foreach giúp chúng ta viết code dễ dàng hơn và đọc nó dễ hơn. Foreach sẽ làm nhiệm vụ chạy qua từng item trong mảng hoặc collection sẽ kiểm tra có còn phần tử nào nằm trong collection mà nó chưa chạy qua hay không, trong trường hợp vẫn còn phần tử như vậy thì nó sẽ gán phần tử tiếp theo của collection vào biến local và thực thi lệnh trong phần thân foreach. Trong trường hợp không còn element nào trong collection thì nó sẽ thoát ra khỏi lệnh foreach
8 9 WhileDoWhileVideo
•	vòng lặp while sẽ cho phép chúng ta có thể thực thi 1 câu lệnh hoặc 1 khối câu lệnh và chừng nào biểu thức chúng ta đưa ra đúng thì cú pháp của câu lệnh while sẽ là 
![image](https://user-images.githubusercontent.com/94780400/179259063-f9371947-0b35-410b-b9e5-a222ba3bf534.png)
-	khối lệnh sẽ được thực thi khi condition này trả về true
•	do while loop cho phép chúng ta chạy khối câu lệnh cho đến khi biểu thức chúng ta đưa ra là false
![image](https://user-images.githubusercontent.com/94780400/179259093-3eccb34f-0e6f-46b9-ad87-98d4bfb3452b.png)
-	thực thi code block và kiểm tra điều kiện condition(nếu true tiếp tục thực thi) nếu false thì dừng lại
8 12 BreakContinueVideo
•	break sẽ được dùng trong vòng lặp để terminate và dùng cho for,foreach, while, do..while
![image](https://user-images.githubusercontent.com/94780400/179259118-8144f159-1b43-4cb4-9332-96821d869dce.png)
![image](https://user-images.githubusercontent.com/94780400/179259146-4071cd31-af8c-4ebf-9a47-744429c1b13e.png)
•	continue dùng để skip việc thực thi current iteration, nó sẽ không break cả loop
![image](https://user-images.githubusercontent.com/94780400/179259182-8e5591fb-9df3-4346-a290-7ba96c022eb3.png)
•	break kết thúc current loop, còn continue sẽ skip thực thi current iteration
7 0 Introduction video
•	array: mảng là cấu trúc dữ liệu cho phép chúng ta tổ chức lưu trữ dữ liệu theo một cách đặc biệt để có thể truy nhập đến, sửa đổi một cách tốt nhất. Cấu trúc dữ liệu được xem như là một tập hợp của data value, mối quan hệ giữa chúng và function có thể áp dụng lên trên dữ liệu
•	mảng trong C# gồm những phần tử thông thường có cùng kiểu và được tổ chức theo thứ tự cụ thể, chúng ta có thể lấy ra phần tử trong mảng bằng cách sử dụng index
7 1 DeclaringArray video
•	mảng trong C# là tập hợp tuần tự của các phần tử có cùng kiểu và có kích thước cố định
•	khi khai báo mảng thì chúng ta sẽ tạo ra rất nhiều vùng nhớ liên kết với nhau trên stack. Vị trí các phần tử trong mảng gọi là index
![image](https://user-images.githubusercontent.com/94780400/179259220-a01a354b-15b5-4fdb-8d97-ef6590755634.png)
Datatype[] arrayName;
7 2 Initialize an array
•	khai báo mảng nhưng chưa khởi tạo mảng trong vùng nhớ
•	mảng là kiểu ref type nên cần sử dụng từ khoá new để có thể tạo ra instance cho mảng
•	các cách gán giá trị tới mảng
-	gán giá trị tới từng element của mảng đó 
-	gán giá trị cho mảng ngay thời điểm khai báo mảng đó
-	có thể vừa khởi tạo mảng vừa gán giá trị cho nó
-	loại bỏ kích thước của array
![image](https://user-images.githubusercontent.com/94780400/179259251-34c92b44-4b56-492d-a3d6-acc45b75c496.png)
7 3 MultiDimentionalArray video
•	C# cho phép chúng ta tạo ra mảng nhiều chiều chẳng hạn bạn muốn khai báo ra mảng 2 chiều kiểu chuỗi chúng ta có thể viết như sau:
![image](https://user-images.githubusercontent.com/94780400/179259266-38a15a62-5207-4fc0-8ee8-a049aa27b332.png)
•	Mảng 2 chiều
![image](https://user-images.githubusercontent.com/94780400/179259289-5673015f-d5cc-482e-ab6b-82aea47ae75e.png)
•	Khởi tạo và access trong mảng 2 chiều
-	Khi khởi tạo mảng 2 chiều thì dùng từ khoá new
![image](https://user-images.githubusercontent.com/94780400/179259307-c61780a8-55a7-436c-bd5e-674454830f80.png)
7 4 Accessing Video
•	Có thể lấy 1 phần tử trong mảng bằng cách sử dụng index, tức là sử dụng vị trí phần tử trong mảng. Lưu ý vị trí các phần tử sẽ bắt đầu từ 0 trở đi chứ không phải là từ 1
![image](https://user-images.githubusercontent.com/94780400/179259332-4b569b3f-d3f6-42b0-9554-4e4d819015de.png)
5 1 DateTime
•	GMT(Greenwich Mean Time) hoặc UT(Universal Time) 
•	1 ngày trong GMT được đo bằng thời gian quay của trái đất xung quanh trục
•	Giờ UTC(Coordinated Universal Time or Temps Universel Coordonné) : sử dụng đồng hồ lượng tử cc đặt trên thế giới.
•	Múi giờ: TimeZone
•	Chuẩn thời gian ISO 8601
![image](https://user-images.githubusercontent.com/94780400/179259367-905e3198-6aae-45e0-8ef4-38413973fdad.png)
•	Date Time trong C#
-	DateTime chứa 2 thành phần đó là Date: ngày tháng năm, Time: giờ phút giây
-	Thời gian trong C# định nghĩa từ 12:00AM 01-01-0001 đến 31-12-9999
•	Cách khởi tạo DateTime trong C# 
-	DateTime(Int32, Int32, Int32): lần lượt Int32 là ngày tháng năm
-	Ví dụ: new DateTime(26-02-2032)
![image](https://user-images.githubusercontent.com/94780400/179259400-778837d6-8d3e-4a33-a018-3075248d492e.png)
•	Common Properties
-	DayOfWeek : trả lại tên ngày trong tuần
-	DayOfYear: trả lại ngày trong năm
-	TimeOfDay: trả lại thành phần thời gian trong kiểu DateTime
-	ToDay: trả lại ngày tại thời điểm gọi thuộc tính today
-	Now : trả lại thời gian hiện tại
-	UtcNow: trả lại thời gian UTC chứ không phải local
5 3 DateTimeFormat Video
•	DateTime format dùng để định nghĩa để hiển thị text cho giá trị date và giá trị time
•	CultureInfo trả lại thông tin của specific culture. Trong DateTime khi chúng ta sử dụng CultureInfo khác nhau thì nó sẽ hiển thị ra định dạng khác nhau
![image](https://user-images.githubusercontent.com/94780400/179259427-53faa67d-e9c7-4ef1-863f-a6de33c40c24.png)
Format DateTime
![image](https://user-images.githubusercontent.com/94780400/179259460-5c164ba7-ae78-45a6-9e4f-8184c8dc0896.png)
•	Convert chuỗi string sang DateTime
-	Phương thức TryParse: convert string thành kiểu datetime và parameter cuối cùng trong phương thức tryparse sẽ out ra kiểu datetime, nếu parse thành công thì nó sẽ trả về true còn nếu không thành công thì trả về false
![image](https://user-images.githubusercontent.com/94780400/179259478-cc868ba3-d4d8-44c6-8d89-8bb735aef315.png)
-	Phương thức TryParseExact: hoạt động tương tự như TryParse nhưng nó cho phép chúng ta truyền format mà chúng ta muốn parse ra![image](https://user-images.githubusercontent.com/94780400/179259521-0f6046d8-27bf-4ff5-a805-5e7c7d693bb8.png)
5 5 TimeSpanAndDateTimeMethods 
•	TimeSpan: biểu thị độ dài của thời gian
•	Khởi tạo TimeSpan
-	TimeSpan truyền vào giờ,phút, giây
-	TimeSpan truyền vào ngày,giờ,phút,giây
-	TimeSpan truyền vào day,giờ,phút,giây,mili giây
![image](https://user-images.githubusercontent.com/94780400/179259543-49bede67-c166-4977-b558-03a3c4a21836.png)
•	Properties 
-	Ngày,giờ,phút,giây, mili giây
•	Phương thức(Methods)
-	Add
-	Compare 2 TimeSpan với nhau
•	DateTime Methods
-	Add: có thể cộng khoảng thời gian vào biến thời gian và chúng ta khai báo và phương thức sẽ trả về kiểu DateTime
![image](https://user-images.githubusercontent.com/94780400/179259577-b24aba3d-2a83-4664-84d4-1d50b0b0ab6d.png)
•	TimeSpan Subtract(DateTime): trừ 2 khoảng thời gian cho nhau
![image](https://user-images.githubusercontent.com/94780400/179259621-351a85e8-3c4d-4707-a764-ec7eb09f789a.png)
•	DateTime method có thể cộng thêm năm, thêm tháng, thêm ngày, giờ,phút, giây, mili giây vào trong 1 datetime![image](https://user-images.githubusercontent.com/94780400/179259649-55dcb444-4647-4e5e-8dad-1ad847f08942.png)
5 7 String Video
•	What is literal
Literal là giá trị chúng ta sẽ hard-coded trực tiếp vào trong source code
Ví dụ:
-	String x = “Hello World;” // Hello World là literal
-	Int y = 2; // 2 là literal
![image](https://user-images.githubusercontent.com/94780400/179259693-e7be26a8-3930-454c-a24f-bccd956fd4d1.png)
•	String là tập hợp của character
•	Đôi khi trong C# chúng ta viết string S là viết thường hoặc  viết hoa
•	Object của string là immutable: có nghĩa là không đổi
![image](https://user-images.githubusercontent.com/94780400/179259716-566a7b93-f1a3-4766-bc23-89f39edaddf3.png)
•	String Escape Sequences: khái niệm Escape để chỉ ra nghĩa thay thế cho nghĩa thông thường. Trong chuỗi khi ta compile 1 dấu backslash và tiếp theo bởi 1 kí tự thì sẽ gọi là escaped sequences![image](https://user-images.githubusercontent.com/94780400/179259744-365932eb-c2e5-446e-b01f-2d6d7d7f8c32.png)
•	Khai báo và khởi tạo 1 chuỗi
-	Datatype + tên biến = gán giá trị
-	Thường hay dùng regular string literal để khai báo
-	Dùng vẻbatim srtring literal để khởi tạo(thêm @ trước chuỗi)
![image](https://user-images.githubusercontent.com/94780400/179259774-2d8c78f5-8476-4e49-895d-fbcc9df6069e.png)
•	Common method cho string
-	Concat: Combine 2 string lại với nhau và trả về string mới
-	Contains: trả về giá trị kiểu int để biết rằng 1 chuỗi có nằm trong 1 chuỗi khác hay không
-	String.Format: convert giá trị của 1 object trở thành kiểu chuỗi dựa trên format mà chúng ta chỉ định(Hay dùng)
-	String.SubString: trả lại 1 chuỗi con từ 1 chuỗi to
![image](https://user-images.githubusercontent.com/94780400/179259817-4d52f423-bd91-44fd-9846-db855b0584f1.png)
5 9 StringBuilder Video
•	String là immutable nghĩa là khi gán giá trị vào string và chúng ta thay đổi giá trị đó thì sẽ tạo ra vùng nhớ mới trong heap cho giá trị thay đổi chứ nó sẽ không ghi đè lại vùng nhớ cũ 
•	Hành động nói trên có thể gây ảnh hưởng tới performance và để giải quyết vấn đề đó thì .NET Framework đã đưa ra Stringbuilder
•	Stringbuilder: khi tạo ra object mới thì nó sẽ tự động resign lại memory ở trong heap cho giá trị mới và sẽ không tạo ra vùng nhớ mới cho chuỗi mới 
![image](https://user-images.githubusercontent.com/94780400/179259871-08d07c63-74f5-4b75-9c7b-298bfb64f34c.png)
•	Cú pháp để khởi tạo Stringbuilder:
-	StringBuilder sb = new StringBuilder();
//or
StringBuilder sb = new StringBuilder(“Hello World!!”);
![image](https://user-images.githubusercontent.com/94780400/179259896-ef58433c-7352-469f-b738-d5a76a3c6e3d.png)
•	Stringbuilder Method
-	Stringbuilder.Append(ValueToAppend): cho phép nối chuỗi vào trong chuỗi hiện tại, vào vị trí cuối cùng của chuỗi hiện
-	Stringbuilder.AppendFormat(): thay đổi format của chuỗi hiện tại 
-	Stringbuilder.Insert(index,ValueToAppend):insert chuỗi mới vào chuỗi hiện tại, chỉ định index vị trí muốn insert
-	StringBuilder.Remove(int startindex, int length): xoá chuỗi
-	Stringbuilder.Repalce(oldValue,newValue): replace tới giá trị chuỗi mới và cũ.
PatternMatchingVideo
•	ParternMatching: toán tử is để kiểm tra xem object của chúng ta có thuộc type nào hay không
![image](https://user-images.githubusercontent.com/94780400/179259917-11039fc6-9514-4c0c-bc25-26690fad9521.png)
StringInterpolationVideo
![image](https://user-images.githubusercontent.com/94780400/179259953-6769a253-cc5e-477b-a75e-103a5ce656ce.png)
•	String Interpolation: giống như một template chứa biểu thức nội suy và khi interpolation trả lại chuỗi sẽ tự động replace những biểu thức này với giá trị mà biểu thức này biểu diễn
![image](https://user-images.githubusercontent.com/94780400/179260066-95d3f57a-e370-49f8-8ade-f4d71c38478a.png)
3 0 OOP Introduction edited
•	What is OOP: Object oriented Programming
Lập trình hướng đối tượng cho phép lập trình viên có thể viết object trong source code, giả lập obj hay đối tượng trong đời sống hằng ngày
•	Object là bất cứ thứ gì có attribute hay thuộc tính và có phương thức(behavior)
•	Ví dụ: 
![image](https://user-images.githubusercontent.com/94780400/179260104-e1bb146f-6754-4e7f-98ce-d9b595b880c2.png)
•	Class là blueprint hoặc template(khuôn mẫu) để từ đó chúng ta có thể tạo ra object
![image](https://user-images.githubusercontent.com/94780400/179260109-66890223-1dba-4404-b7f9-2b7856422d5c.png)
•	Ví dụ về class
![image](https://user-images.githubusercontent.com/94780400/179260134-96009b5d-443e-438d-8fb5-b4063bf424d1.png)
3 1 ClassDesign
•	Class, Object Recall: Class là một khuôn mẫu mà từ đó ta có thể tạo ra được object
•	Còn một object có thể hiểu là khởi tạo, là một instance của class
•	Designing a class: để thiết kế ra một class thì cần nghĩ về object mà sẽ được tạo ra từ class đó
-	Một object gồm 2 thành phần bao gồm : attribute(thuộc tính) và behavior(phương thức)
![image](https://user-images.githubusercontent.com/94780400/179260643-ee929e09-0436-4dcb-b1f4-f3c42d67df3c.png)
-	Ví dụ một giỏ hàng có những hành động thêm product vào giỏ hàng thì chúng ta tạo ra method addToCart(), RemoveFromCart(),CheckOut
•	Instance variables là những thứ cho biết một object biết về bản thân nó hoặc gọi là properties hoặc attributes
•	Những object instance variable thể hiện ra trạng thái của object đấy
•	Object can do thì chúng ta gọi là method và tập hợp method này sẽ biểu thị ra hành vi hay còn gọi behavior của obj
•	Ví dụ về class 
![image](https://user-images.githubusercontent.com/94780400/179260682-76dd0c9b-0a0e-4c4b-91ff-4f6792156e8f.png)
![image](https://user-images.githubusercontent.com/94780400/179260699-6509ad58-7d59-4e0c-80c9-5ff5dcd095f5.png)
3 2 Constructor
•	Constructor được sử dụng để tạo ra object từ class, có thể coi constructor là member function đặc biệt vì :
-	Nó có cùng tên với tên class
-	Constructor được gọi bất cứ khi nào object được tạo ra
-	Constructor không có kiểu giá trị trả về 
-	Constructor là function nên cho phép truyền parameters vào function đó
-	Constructor có thể overloaded
-	Khi mà chúng ta không định nghĩa constructor trong 1 class thì compiler tự động tạo ra Constructor đặc biệt gọi là Default Constructor và Default Constructor sẽ không có parameter nào cả
3 3 Namespace
•	Namespace được thiết kế để tránh class trùng tên với nhau và giảm thiểu conflict giữa các class. Khi mà một class được định nghĩa trong một namespace thì nó sẽ không bị conflict với class trùng tên
•	Ví dụ về Namespace 
3 4 Class Lab Edited
3 4 Class Lab Edited
•	 
3 5 PropertiesAndMethods
•	Object có 2 thành phần chính:
-	State(Trạng thái), state được biểu thị thông instance variable hay còn gọi là properties hoặc attribute
-	Hành xử của object(Behavior)(Method)
•	Những method trong 1 class có thể sử dụng attribute value và nó sẽ thay đổi object state đó
•	Chính vì thay đổi được state đó nên những object có cùng 1 kiểu có thể hành xử khác nhau 
 

 

•	Giữa method và properties có quan hệ 2 chiều, thì method có thể thay đổi properties của 1 object và ngược lại properties có thể ảnh hưởng đến method. Chính vì thế object có cùng kiểu nhưng có thể hành xử khác nhau
3 6 Encapsulation
•	Tính đóng gói: được sử dụng để che giấu thông tin trong 1 object, ví dụ có 1 attribute và không muốn visible ra bên ngoài thì chúng ta có thể bundle nó vào trong method và method đó sẽ đọc và ghi tới attribute đó và thế giới bên ngoài sẽ chỉ làm việc với method này thôi và không làm việc với attribute
•	Encapsulation/ Information Hiding
 
-	Set thuộc tính method là private
•	Ưu điểm của Advantages
-	Tất cả độ phức tạp của code sẽ được ẩn giấu bên trong objet và client chỉ việc sử dụng mà không cần biết đến bên trong
-	Gây ra ít lỗi
3 7 AccessModifiers
•	Access Modifiers là keywords set ra mức độ truy cập đến class, method, và attribute. accessModifiers được đưa ra để thực hiện tính đóng gói trong oop
•	C# cung cấp 4 loại accessmodifiers chính:
-	Public: mức độ truy cập ở bất cứ đâu và bởi bất cứ ai, độ bảo mất thấp nhất
-	Protected: khi một class,method,attribute được set là protected thì có nghĩa là class,method,attribute này chỉ được truy cập bởi chính class đó hoặc class con kế thừa từ class cha
-	Internal: khi sử dụng internal thì quyền truy cập chỉ trong nội assembly
-	Private: chỉ truy cập nội bên trong object đó và bên ngoài không thể truy cập vào
•	Khi không chỉ định ra accessmodifiers cho class thì mặc định là internal
•	Default access modifiers cho attribute,method, constructor  của class là private
 
3 9 Inheritance
•	Tính kế thừa: sẽ cho phép bạn định nghĩa ra lớp con có thể sử dụng lại hoặc mở rộng sửa đổi behavior lớp cha. Tính kế thừa này cũng giống như trong thực tế ngoài đời song: ví dụ con cái kế thừa đặc tính của cha mẹ như hình dáng, màu mắt, màu tóc
•	Những class mà member của nó được kế thừa thì chúng ta gọi là lớp cha hay còn gọi là base class
•	Còn những lớp con kế thừa từ lớp cha thì chúng ta gọi là lớp con hay derived
•	C# nói riêng và .NET nói chung chỉ hỗ trợ single inheritance  có nghĩa là một lớp con chỉ có thể kế thừa từ một lớp cha duy nhất, nhưng một lớp cha thì có thể có nhiều lớp con
•	Ví dụ: 
 
1.	Tìm ra đặc tính chung của object
-	Picture
-	Food
-	Hunger: biểu thị mức độ đói của con vật đó
-	Boundaries: vùng không gian cho phép con vật đó đi lại
-	Location: toạ độ
 
2.	Tìm ra behavior chung:
-	makeNoise(): tạo ra âm thanh
-	eat(): việc ăn của từng loại con vật
-	sleep(): ngủ
-	roam: kiểu đi lang thang của từng con
 
3.	Design class
 
4.	Tạo hierarchy
 
5.	Những behavior nào nên overrides
-	Overrides Phương thức makeNoise,eat
 
6.	Refine hierarchy
 
-	Nên overrides lại phương thức roam()
•	Lợi ích của tính kế thừa 
-	Nhờ có kế thừa mà chúng ta có thể minimize được code bị trùng lặp, tránh dư thừa
-	Data hiding: có những dữ liệu mà chúng ta có thể private ở lớp cha mà lớp con không thể thay đổi được
-	Overriding: lớp cha define ra phương thức và thuộc tính nhưng việc implement một cách tường minh thì chúng ta sẽ để ở lớp con
3 12 Abstraction
•	Abstraction: tính trừu tượng hoá sẽ tập trung vào quá trình che giấu đi những chi tiết không cần thiết và sẽ thể hiện ra bên ngoài đặc tính cơ bản của object cụ thể
•	Ví dụ class car được tạo ra bởi rất nhiều thành phần như động cơ, hộp số, vô lăng.v.v… tuy nhiên khi nói đến oto chỉ nói đến thành phần cơ bản nhất như nó có động cơ, hộp số thay vì đi sâu vào bên trong và đưa ra vấn đề làm sao để oto chạy và khởi động động cơ. Thì đây chính là trừu tượng hoá 
•	Về mặt ngữ nghĩa thì trừu tượng có nghĩa là liên quan đến ý tưởng, concept hơn là liên quan đến instance cụ thể
•	Trong lập trình chúng ta có thể áp dụng tính trừu tượng bằng cách tạo ra class sẽ không liên quan gì đến instance cụ thể nào
 
Animal ở đây là abstraction class
•	Abstraction vs Encapsulation
-	Cả 2 đều nhằm mục đích che giấu thông tin tới thế giới bên ngoài
•	Khác biệt giữa Abstraction vs Encapsulation
-	Abstraction giải quyết việc che giấu thông tin ở mức design. Encapsulation giải quyết việc che giấu thông tin ở mức triển khai(implementation level)
-	ở mức thiết kế abstraction có thể tạo ra class là abstraction bằng cách sử dụng từ khoá abstract hoặc sử dụng interface. Còn Encapsulation sẽ được implement bằng cách sử dụng access modifiers(Private, protected)
3 14 Polymorphism
•	Polymorphism: tính đa hình có nghĩa là 1 object có thể hành xử dưới nhiều dạng thức khác nhau hoặc chúng ta có thể nói là với cùng 1 method và 1 properties thì nó có thể thực thi khác nhau phụ thuộc vào loại object ở thời điểm runtime thực thi method và properties đó
•	Ví dụ: cùng 1 người thì người đó có thể hành xử như một người con ở trong gia đình, tuy nhiên cùng thời điểm thì người đó hành xử như một nhân viên tại văn phòng
 
 
	Cùng gọi đến 1 phương thức nhưng kết quả hiện ra lại tuỳ thuộc vào instance lúc tạo thì đây chính là tính đa hình
3 15 Inteface
 
•	Ví dụ yêu cầu chương trình PetShop phải có 2 behavior
-	beFriendly()
-	Play()
 
•	Xử lý: tiếp cận từ trên xuống thêm 2 phương thức ở class animal
-	Ưu điểm của cách này bao gồm: tất cả class đều đc kế thừa và chương trình PetShop hoàn thành được tính đa hình của nó
-	Nhược điểm: class Hippo, lion, wolf cũng là vật nuôi thì nghe có vẻ không hợp lý
 
•	Cách tiếp cận thứ 2:  đi từ dưới lên, có thể con chó hoặc con mèo là vật nuôi thì chúng ta có thể đẩy method đó vào cat và dog
-	Ưu điểm là : Hippo,lion,wolf không còn là vật nuôi
-	Nhược điểm: tuy nhiên lại làm mất tính đa hình đã thiết kế trước đó
 
	Những pet behavior chỉ nằm trong class pet mà thôi	và những class nào vừa là pet thì sẽ phải kế thừa cả pet và animal, ví dụ cat ở đây kế thừa từ pet và kế thừa từ feline và dog cũng tương tự. Thì cách kế thừa này sẽ đảm bảo tính toàn vẹn(polimorphism) và tính kế thừa, tuy nhiên có 1 vấn đề 1 class chỉ đc kế thừa từ 1 class cha và giờ phải làm sao
	Thì bây giờ khái niệm interface ra đời để vượt qua vấn đề trên. Interface sẽ định nghĩa ra các properties , method, event mà chúng ta gọi là member của interface và các interface này sẽ chỉ chứa các khai báo về các member này mà thôi. Còn việc implement chi tiết các member này sẽ do class kế thừa định nghĩa ra
•	 
-	Quay lại vấn đề: không phải tạo ra class pet nữa mà tạo ra interface có tên là pet và lúc đó cat sẽ kế thừa từ pet và cả class Feline
13	 OverloadVideo
•	Polymorphism có nghĩa là object có thể hành xử dưới nhiều dạng thức khác nhau, trong C# có 2 loại Polymorphism
•	Static Polymorphism: đa hình tĩnh thì việc quyết định gọi method nào của object tức là hành xử của object đấy sẽ được quyết định ở thời điểm compile. Chính vì vậy static polymorphism được gọi là compile polymorphism, để thực thi đa hình tĩnh này chúng ta cần phương pháp overloading(nạp chồng). Trong overloading có 2 kiểu 
-	Method overloading:
-	Operator overloading:
•	Dynamic Polymorphism: đa hình động quyết định xem gọi method vào, hành xử nào của 1 object được quyết định ở thời điểm runtime. Để thực thi Dynamic Polymorphism thì chúng ta sử dụng :
-	Method overriding
•	Method overloading cho phép chúng ta tạo ra nhiều method trong cùng một class có cùng tên nhưng khác nhau về parameters và type truyền vào. Có thể thực thi method overloading bằng 1 trong 3 cách sau
-	Thay đổi số lượng parameter cho các method ở trong class đó
-	Thay đổi order thứ tự của parameter đó 
-	Sử dụng loại datatype khác nhau cho parameter
-	Ví dụ:
 
13 3 ConstructorOverloadingVideo
•	Constructor Overloading là một công nghệ cho phép chúng ta có thể tạo ra nhiều constructor nó chỉ  khác nhau ở tập hợp parameter truyền vào cho constructor. Với việc sử dụng constructor overloading thì cho phép chúng ta sử dụng class theo nhiều khía cạnh khác nhau
 
-	Tạo class rectangle thì trong đó có 2 properties là chiều cao và rộng, sau đó thì có một constructor truyền vào 2 biến chiều cao và chiều rộng để mình set giá trị cho chiều cao và rộng của rectangle này
-	Tiếp theo có constructor thứ 2: làm nhiệm vụ tạo ra hình vuông(trường hợp đặc biệt), chiều cao rộng bằng nhau, thì với hình vuông lúc này sẽ chỉ cần truyền vào thông số là size và sau đó set chiều rộng và chiều cao cùng bằng giá trị là size
	Tạo ra constructor overloading, tạo ra 2 constructor chỉ khác nhau ở số lượng parameter truyền vào và với việc tạo ra 2 constructor thì mình có thể sử dụng class như một hình chữ nhật hoặc sử dụng class này như hình vuông
•	Constructor calling: trong thực tế tạo ra class có thể có rất nhiều properties trong class đó thì constructor có thể trở nên rất phức tạp, rất lớn với nhiều parameter và khi chúng ta sử dụng constructor overloading thì các constructor này sẽ lặp đi lặp lại khiến chúng ta chán nản khi code. Thì để tránh điều này thì C# cho phép chúng ta tạo ra một constructor bằng việc gọi một constructor sẵn có
-	Cú pháp: 
 
Trong đó public access modifiers + constructor(truyền vào tham số): từ khoá this(truyền vào danh sách tham số). Lưu ý parameter 2 phải là tập con của parameter 1
 
13 5 MethodOverridingVideo
•	Method overriding được sử dụng để tạo ra dynamic polymorphism tức là 1 object có thể gọi đến một method của behavior của nó tại thời điểm runtime, để thực hiện việc đó method overriding cho phép chúng ta có thể tạo ra method ở lớp con có cùng tên, cùng parameter, cùng giá trị trả về giống như lớp cha(base class)
-	Method overriding chỉ được thực thi ở lớp con, chúng ta không thể overriding một method trong cùng 1 class
-	Một method ở lớp cha muốn cho lớp con có thể overriding thì method đó cần phải dùng 1 trong 2 tùw khoá là virtual hoặc abstract
•	Ví dụ:
 
13 7 Overload vs OverrideVideo
•	So sánh Overload và Override
•	Giống nhau:
-	Cùng thực thi tính đa hình trong lập trình hướng đối tượng 
•	Khác nhau: 
	Overload: 
-	Cho phép chúng ta tạo ra nhiều method trong cùng một class có cùng tên nhưng khác tham số truyền vào và kiểu dữ liệu truyền vào
	Override:
-	Cho phép chúng ta tạo ra method ở trong lớp con có cùng tên, cùng tham số và cùng kiểu dữ liệu trả về giống như lớp cha
-	Khi override một method ở lớp con thì method ở class chả phải kèm theo từ khoá virtual hoặc abstract
•	Virtual Method
-	Virtual method có thể implement code trong virtual method và virtual method có thể nằm trong abstract class
-	Không bắt buộc lớp con phải override virtual method đó
•	Abstract method
-	Không có implementation
-	 Bắt buộc lớp con phải override bởi vì không có implementation
13 8 StaticMethodVideo
•	Static method hay còn gọi là class method
 
•	Cho ví dụ sau: có biến x kiểu double và sau đó gán giá trị của x = Math(class dựng sẵn của C#) và trong class Math này gọi đến method Round sẽ làm nhiệm vụ làm tròn con số(truyền vào là 100.5). 
•	Tiếp theo khai báo biến y kiểu int và cũng gọi method là abs(tính trị tuyệt đối trong class math) và truyền giá trị -10
	Khi in giá trị x,y ra màn hình thì sẽ trả lại giá trị x = 100; y = 10
•	Static method có thể hiểu là method có thể chạy mà không cần quan tâm tới instance
 
•	Regular method
-	Một instance variable sẽ affect behavior của một method. Như trong ví dụ trên nếu thay đổi tên thì sẽ thay đổi nội dung greeting
-	Regular method sẽ cần gọi nó từ instance
•	Static method
-	Không thể access tới variable của class, nó sẽ chỉ quan tâm tới parameter truyền vào cho nó mà thôi
-	Có thể sử dụng luôn class và gọi đến method đó
 
	Một static method không thể sử dụng instance variable hoặc instance method
13 9 StaticVariableVideo
•	Static variable còn được gọi là class variable, static variable phụ thuộc vào class chứ không phụ thuộc vào object cụ thể nào
•	Sử dụng static variable như một bản copy được sử dụng giữa instance của class
•	Ví dụ:
 
13 10 StaticClassVideo
•	Static class là một class mà chúng ta không thể tạo object từ nó(không thể instantiated). Một static class chỉ chứa một static member(chỉ chứa static variable hoặc static method). Static class có 2 đặc điểm:
-	Static class là sealed tức là không thể tạo ra class kế thừa từ static class
-	Static class không chứa instance constructor
 
13 12 SealedVideo
•	Sealed on a class: có thể áp dụng được ở mức class, method, properties, khi mà sử dụng từ khoá sealed cho một class thì chúng ta muốn ngăn class khác có thể kế thừa class sealed
 
•	Sử dụng sealed cho method hoặc properties đã override virtual method hoặc property ở lớp base class
•	Sử dụng sealed trên method và property cho phép class khác kế thừa class của bạn, tuy nhiên ngăn class kế thừa override virtual method
 
13 13 AutomaticPropertiesVideo
•	Có ví dụ về autoProperties 
 
	Get là trả lại giá trị, set là gán giá trị
10 1 ExceptionVideo
•	Exception: chính là vấn đề nảy sinh khi chúng ta thực thi chương trình, một exception trong C# chính là phản hồi về tình huống ngoại lệ xảy ra khi chương trình đang chạy
•	C# cung cấp cho chúng ta cách xử lý exception bằng cách xử dụng 4 keywords là : try, catch, finally và throw
•	Ví dụ về exception:
 
Chương trình cho xe tự lái, thì chương trình cần phải phát hiện ra xe khác đang chạy đằng trước bỗng dung dừng lại, và phải thiết kế phần mềm coi như đây là vấn đề ngoại lệ
10 2 ExceptionvsErrorVideo
So sánh exception vs Error
•	Khi mà viết code hoặc thực thi chương trình trong C# thì nó thường có những loại lỗi sau xảy ra
-	Syntactical Error: lỗi cú pháp, ví dụ quên dấu ; và dùng ide để check lỗi
-	Compilation Error: lỗi trong quá trình compile
-	Runtime Error: chỉ xảy ra khi thực thi chương trình, ví dụ cố gắng đọc file mà không được cấp quyền
-	Lỗi runtime error chính là một exception bởi vì nó sẽ termination chương trình đang chạy và để tránh termination chương trình đang chạy thì chúng ta cần handle exception đó.
10 3 TryCatchVideo
•	Nhắc lại lý thuyết: exception chính là runtime error và nó sẽ terminate chương trình đang chạy, để tránh chương trình bị terminate thì chúng ta cần handle exception đó với keywords: try-catch, finally, throw
•	Cấu trúc của try-catch: gồm 2 phần
-	Try: là block của code mà nó có thể gây ra exception và đi theo sau try-block thì có một hoặc nhiều catch
-	Catch: là nơi mà bắt exception và xử lý exception
-	Cú pháp: 
 
•	Exception classes
-	Exception trong C# được biểu diễn bởi class và các class này sẽ kế thừa trực tiếp hoặc gián tiếp từ class system.exception
-	2 class kế thừa từ system.exception đó là system.applicationException và system.SystemException
•	Exception hierarchy
 
•	Exception Properties
Exception có những thuộc tính sau:
-	Message: cung cấp chi tiết nguyên nhân gây ra lỗi
-	stackTrace: 
-	InnerException: khi catch một exception thì có nhiều khả năng chúng ta throw lại exception mới, thì khi mà chúng ta Re-write một exception mới thì chúng ta có thể pass original exception vào trong InnerException
-	HelpLink: đưa ra một số link C# dựng sẵn
-	Data: thuộc tính cho phép ta lock thêm một số thông tin hữu ích, hiển thị dữ liệu dưới dạng key value
-	TargetSite: chỉ ra tên method gây ra exception  
10 6 FinallyVideo
•	Finally: dùng để cleanup object mà nó holding external resources, việc cleanup object này sẽ diễn ra ngay lập tức ngay cả khi exception được throw ra
•	Ví dụ: chương trình thao tác với database mà chúng ta phải tạo ra connect tới db thì object lưu trữ connection tới db đó thì chúng ta gọi đó là object holding external resources tức là nguồn tài nguyên bên ngoài, số lượng connect đến db có hữu hạn chính vì vậy khi sử dụng xong thì phải đóng lại connection đó. Trong trường hợp chương trình gặp exception đó, trước khi mà chúng ta đóng connection thì chúng ta phải đợi barbage collection sẽ cleanup object thì có thể diễn ra chậm hơn và gây ra trường hợp giới hạn connect db chính vì vậy phải sử dụng finally. Bởi vì finally sẽ cleanup object ngay lập tức
•	Ví dụ code:
 

10 7 ThrowVideo
•	Tự hỏi rằng làm thế nào để ném ra một exception
•	Trả lời: sử dụng câu lệnh throw
•	Trường hợp tự throw ra exception
-	Khi method không thể hoàn thành chức năng mà chúng ta định nghĩa cho nó, ví dụ:một parameter cho method truyền vào giá trị invalid
 
-	Gọi tới một object mà trạng thái object không cho chúng ta làm điều đó. Ví dụ:
Cố gắng viết vào readonly file thì trong trường hợp trạng thái file đó sẽ không cho phép thực hiện operation write
 
-	Khi argument của một method causes exception thì trong trường hợp này nên bắt original exception và throw ra instance ArgumentException
 
10 9 CustomExceptionVideo
•	Custom Exception: Trong C# chúng ta có thể tạo ra customer exception bằng cách kế thừa exception class hoặc từ ApplicationException
•	Microsoft: warning chúng ta nên tạo ra customException kế thừa trực tiếp từ exception thay vì sử dụng applicationexception. Bởi vì trong thực tế ko có quá nhiều lợi ích từ api exception
•	Ví dụ:
 
 
10 12 ExceptionFilterVideo
•	Exception filter là một trong những major feature mới của C# 6.0, nó cho phép chúng ta chỉ định condition trong catch block
 
11 1 GenericVideo
•	Generic: được thêm vào .NET Framework từ version 2.0 trở đi, và cho phép chúng ta delay việc chỉ định datatype của những thành phần trong một class hoặc trong một method cho đến khi sử dụng trong chương trình. Hay nói cách khác generic cho phép chúng ta viết ra những class hay method có thể làm việc với bất kể loại datatype nào
•	Ưu điểm của  generic: 
-	Maximize code reuse, hỗ trợ type safety và performance
-	Use case phổ biến nhất của generic là tạo ra collection classes
-	Tạo ra generic ở trên interface, classes, method, event và trên delegate
-	Thông tin về generic data type có thể lấy ra tại thời điểm runtime bằng cách sử dụng reflextion
11 2 GenericClass Video
•	Generic class nó sẽ đóng gói các operation mà không chỉ định tới loại data type cụ thể nào 
•	Có thể tạo class trở thành generic class bằng cách thêm kí hiệu <T> 
 
 
 
11 4 GenericMethod Video

•	Trong C# để biến method trở thành generic thì cần phải add thêm kí hiệu <T> và sau tên method trước dấu mở ngoặc để truyền parameter
 
•	Ví dụ:
 
11 5 GenericInterface Video
•	Generic interface cũng tương tự như generic class, chúng ta có thể define ra parameter T ở mức interface và method ở trong interface đó thì cũng có thể sử dụng parameter này, và những method ở trong class mà class implement generic interface cũng cần phải inplement parameter T
•	Ví dụ:
 
11 6 Collection Video
•	Collection: trong C# cung cấp một số class đặc biệt để có thể lưu trữ giá trị hoặc object theo chuỗi cụ thể gọi là collection
•	Có 2 loại collection là : non-generic collection và generic collection 
•	2 loại collection này chia sẻ với nhau một số điểm chung sau
-	Tất cả đều implement loại interface IEnumblerable bởi vậy chúng ta có thể sử dụng vòng lặp foreach để truy cập đến các item trong collection
-	Tất cả đều có thể copy tới mảng sử dụng method copyto
-	Tất cả index collection tron namespace System.collection đều sử dụng 0-indexed
-	Một số collection đều có capacity, một số khác có count, một số thì có cả 2. Capacity cho chúng ta biết collection đấy chứa bao nhiêu item, còn count thì cho chúng ta biết hiện thời có bao nhiêu item
•	Non-generic collections: nó sẽ store item giống như object có nghĩa rằng là item của thể loại non-generic collection có thể là bất kể loại data type nào. Chính vì vậy khi mà chúng ta retrieving, get lại item của loại collection này thì sẽ cần cast trở về một loại datatype cụ thể
•	Trong bài này sẽ có 3 loại non-generic collection
-	ArrayList
-	HashTable
-	SortedList
•	Generic collection : bên trong sẽ lưu trữ element dưới dạng array chính vì vậy phải chỉ định data type khi sử dụng generic collection và không cần phải boxing và casting item này. Trong bài này sẽ có 2 loại generic collection
-	List
-	Dictionary
11 7 ArrayList Video
•	Trong C# thì ArrayList khá giống với array ngoại trừ chúng ta không cần phải chỉ định kích thước cho arraylist và không cần phải chỉ định datatype cho arraylist, khi add item cho arraylist thì tự động kích thước của arraylist được tăng lên
•	Cú pháp
 
•	Properties của arraylist bao gồm:
-	Capacity: cho phép get hoặc set số lượng element ở trong một  
-	Count: trả về số lượng element mà arraylist đang chứa.
•	Common method 
-	Add(): cho phép chúng ta thêm single element vào cuối của một arraylist
-	 AddRange(): cho phép chúng ta add element từ một collection khác vào arraylist
-	Insert(): insert một element vào một vị trí mà ta chỉ định trong arraylist
-	insertRange: cho phép insert element từ một collection vào arraylist từ một vị trí mà ta chỉ định
-	remove(): cho phép xoá element mà ta chỉ định từ arraylist
-	removeRange(): xoá một range element ra khởi arraylist
-	Containts: kiểm tra element cụ thể có tồn tại trong arraylist hay không, nếu tồn tại trả về true và nếu không trả về false
11 9 SortedList Video
•	Sortedlist collection cho phép chúng ta lưu trữ dưới dạng key value pairs, dưới dạng khoá và giá trị giống như hashtable, tên là sortedlist thì mặc định sắp xếp theo thứ tự tăng dần và sortedlist có thể implement cả 2 interface IDictionary & ICollection nên có thể truy cập vào item của sortedlist bằng key hoặc index
•	Cú pháp: 
 
•	Thuộc tính cơ bản của sortedlist(common properties)
-	Capacity: cho phép chúng ta get và set số lượng item mà một sortedlist có thể chứa
-	Count: trả về tổng số item mà hiện giờ sortedlist đang chứa
-	Keys: trả về key mà sortedlist chứa
-	Values: trả về giá trị mà sortedlist chứa
•	Method cơ bản của sortedlist(common method)
-	Add: thêm item với key và value vào trong sortedlist và tự động sortedlist sẽ order vào đúng vị trí của nó
-	Remove: xoá item ra khỏi sortedlist dựa trên key mà chúng ta truyền vào
-	Clear: xoá tất cả item trong sortedlist
-	Contains/containskey: kiểm tra xem key có tồn tại trong sortedlist hay không 
-	Containsvalue: kiểm tra xem value có tồn tại trong sortedlist hay không.
11 11 HashTableVideo
•	hashTable: trong C# sẽ cho phép chúng ta có thể lưu dưới dạng key-value pairs(dạng khoá và giá trị). Bên trong hashtable sẽ băm khoá của chúng ta thành hashcode và hashcode này sẽ được lưu ở different bucket vì vậy khi lấy ra một giá trị thì thực ra hash table sẽ match hashcode đó với key của chúng ta và sẽ tăng performent lúc tìm kiếm 
•	Cú pháp:
 
•	Thuộc tính cơ bản(common Properties):
-	Count : trả lại tổng số cặp key-value mà hashtable đang chứa, hashtable không có thuộc tính capacity
-	Keys: trả lại tập hợp mà hashtable đang có dưới dạng ICollection
-	Values: để lấy lại tập hợp value trong hashtable
•	Method cơ bản của hashtable(common methods)
-	Add: cho phép chúng ta add item dưới dạng key value vào trong hashtable
-	Remove: cho phép xoá item với key chúng ta chỉ định từ hashtable
-	Clear: xoá tất cả item trong hashtable
-	Containskey: kiểm tra hashtable có chứa key chúng ta truyền vào hay không
-	containsValue: kiểm tra value truyền vào có tồn tại hay không
11 13 DictionaryVideo
•	Dictionary: trong C# giống quyển từ điển tiếng anh, bao gồm những từ và giải nghĩa cho từ đó thì tương tự như vậy dictionary là tập hợp của key và value, trong đó có thể key là từ và value là giải nghĩa
•	Dictionary là loại generic collection, chính vì vậy chúng ta cần sử dụng là <Tkey, TValue>, tất cả generic collection đều được include trong namespace gọi là system.collection.Generic
•	Cú pháp
 
•	Thuộc tính cơ bản của Dictionary(Common Properties)
-	Count: trả về số lượng element đang tồn tại trong dictionary đó, ngoài ra có thể lấy ra danh sách <TKey, TValue>
•	Phương thức của dictionary(Common method)
-	Add: cho phép thêm item vào trong dictionary đó
-	Remove: cho phép xoá element với key chỉ định
-	Clear : xoá tất cả item trong dictionary
-	ContainsKey/ConTainsValue: kiểm tra xem value truyền vào có tồn tại hay không
11 15 ChoosingCollectionVideo
Chọn collection phù hợp trong C#
•	Non-generic collection: cho phép store item dưới dạng object ở bất kì loại datatype nào. Trong Non-generic collection có 3 loại:
-	ArrayList: hoạt động như mảng cho phép chúng ta lưu danh sách của item, chẳng hạn lưu danh sách của product
-	Hashtable: lưu trữ dưới dạng key-Value
-	SortedList: muốn lưu trữ dưới dạng Key-Value nhưng lại muốn key được sắp xếp thì không phải làm nhiệm vụ sorted hay compare thì nên sử dụng sortedlist
•	List thì giống arraylist
•	Dictionary giống hashtable
AnnotationVideo
•	Annotation: là chuỗi của attribute mà chúng ta có thể thêm vào trong một class để apply validation rules tới class của chúng ta
•	Ví dụ: 
 
•	Về cơ bản data annotations chỉ là thuộc tính tức là chỉ là metadata, tự thân nó sẽ khôn validate để xem giá trị gán vào có là validate hay không mà để kiểm tra xem là thuộc tính của chúng ta có được valid hay không thì cần sử dụng validator class
 
AnonymousMethodVideo
•	Anonymouse method: là phương thức nặc danh, có nghĩa là có thể tạo ra phương thức mà không phải chỉ định tên. Trong C# để tạo ra một phương thức nặc danh thì cần sử dụng từ khoá delegate
 
•	Phương thức nặc danh có đặc tính có thể access tới biến mà được khai báo bên ngoài nó
 
•	Tuy nhiên biến được khai báo bên trong phương thức nặc danh thì bên ngoài không access được 
•	Thông thường sử dụng phương thức nặc danh để envent handling
 
AnonymousTypeVideo
•	C# cung cấp cho chúng ta một cách thức tiện lợi để có thể đóng gói một số thuộc tính readonly vào trong một object mà không cần phải chỉ định kiểu cho object đó
 
•	Phạm vi của anonymous type: cũng giống như biến local thông thường và chúng ta chỉ có thể sử dụng anonymous type trong method mà chúng ta đã defined, tuy nhiên khác với biến thông thường là có thể truyền nó như parameter vào một cái method. Anonymous type không thể truyền parameter vào method, ngoại trừ method đó sử dụng từ khoá dynamic
 
•	Anonymous types hay được sử dụng trong linq
 
DelegateVideo
•	Delegate: một function thì có thể có một hoặc nhiều parameter thậm chí là không có paratmer nào và parameter có thể thuộc bất kì loại datatype nào. Tuy nhiên nếu trong trường hợp muốn truyền một function giống parameter vào một function khác thì làm sao để làm đc việc đó.
•	Trong c# nếu bạn muốn khai báo một con trỏ hàm tức là muốn truyền một function giống parameter tới function khác thì chúng ta sử dụng từ khoá delegate. Thì delegate là kiểu references data type mà nó giữ references tới method đó
 
•	Khi biến Print thành delegate thì nó có thể trỏ tới bất kì method nào nhận parameter là kiểu int mà trả lại là kiểu void
•	Ví dụ:
 
•	Để thực thi delegate là references tới method nên chúng ta có thể invoked một delegate giống như invoked một method
 
EventVideo
•	Cho ví dụ: Microsoft khởi động một sự kiện dành cho lập trình viên, giới thiệu về tính năng mới của sản phẩm thì khi Microsoft làm ra sản phẩm như vậy họ cần phải thông báo cho dev biết về sự kiện đó bằng cách gửi mail hoặc quảng cáo qua google hay facebook. Trong trường hợp này chúng ta coi Microsoft là publisher và sau đó người ta phải notifies tới dev về sự kiện đó, khi dev biết về event thì sẽ phải đăng kí tức là chúng ta là subcribers của event và khi event hiện ra chúng ta sẽ phải tham dự(attend) hay nói cách khác là handle event đó.
•	 
•	Trong C# thuật ngữ event cũng tương tự như phía trên cũng sẽ có publisher(là nơi lưu và write ra event), cũng có subscriber để register đến event đó. Có notification publisher notify đến subscriber và nó cũng có handle để subscriber có thể handle event
•	Event đơn giản chỉ là đóng gói của delegate
ExtensionMethodVideo
•	Extension method: cho phép chúng ta thêm các method vào một kiểu data type đã tồn tại mà không cần phải tạo ra class mới kế thừa từ data type, datatype có thể là kiểu int, string.v.v.v. Chúng ta không cần phải recompiling hoặc modify sources code của type original
 
LambdaExpressionVideo
•	Lambda expression cho phép chúng ta viết ra những method một cách tiện lợi
•	Ví dụ: 
 
 
OptionalAndNamedParamVideo
•	Optional and Named Parameter
 
PrivateVsPublicAssemblyVideo
•	Private Assembly: Trong C# có 3 loại assembly
-	Private Assembly: chỉ sử dụng bởi một ứng dụng
-	Private Assembly: sẽ được stored trên directory hoặc sub-directory
-	Private Assembly không cần strong name
•	Public Assembly:
-	Public Assembly: có thể sử dụng bởi multiple application(viết xong project có thể biến nó thành một assembly)
-	Public Assembly: được stored trên GAC(Global Assembly Cache)
-	Public Assembly: đòi hỏi phải có Strong name
QueryExpressionVideo
•	LinQ(Language Integrated Query) là cú pháp cho phép chúng ta truy vấn dữ liệu có cấu trúc nó được built in trong C# để chúng ta có thể save nhận dữ liệu từ data source khác nhau
 
 
•	Cú pháp query linq có 2 cách:
-	Query syntax
 
-	Method syntax:
 
NullConditionalVideo
 
•	Từ C# 6.0 trở đi đã có operator đặc biệt gọi là null conditional,sẽ giúp cho chúng ta không phải viết code dài dòng và lặp đi lặp lại nữa, và sẽ có 2 kiểu cú pháp đó là 
-	?. hay còn gọi là elvis operator
-	?[ 
  
12 1 Concurrency Video
•	Concurrency: là cố gắng làm nhiều hơn một việc tại một thời điểm, chẳng hạn chúng ta có: 
-	ứng dụng end-user thì ứng dụng này có thể sử dụng concurrency để phản hồi lại những user input mà khách hàng nhập lên form trong khi nó vẫn đang viết request đó xuống database
-	ứng dụng server nó sẽ cần phản hồi rất nhiều request client gửi lên thì server application có thể sử dụng concurrency để phản hồi yêu cầu thứ hai trong khi vẫn đang cố gắng hoàn thành phản hồi đầu tiên
12 1 ThreadVideo
•	Process and Thread
•	Tiến trình(Precess) là chương trình đang chạy trên máy tính, và một chương trình thì có thể associated tới nhiều process. Ví dụ có thể mở ra chương trình caculater trên máy tính và mở nhiều instances của calculator và mõi instances đấy tương đương với một process
•	Ví dụ:
 
•	Thread thực ra chính là sắp xếp, tức là tập con của process. Có nghĩa rằng là trong một process thì có một hoặc nhiều thread và các thread này được đặt lịch để chạy chương trình của chúng ta. Thread có thể hiểu là đơn vị cơ bản mà hệ điều hành sẽ allocate resource để có thể chạy ứng dụng
•	Trong C# những chươngg trình như Console được viết từ đầu đến giờ thì tự động thằng CLR và hệ điều hành sẽ tạo ra thread mặc định cho chúng ta và những chương trình đó chạy trên thread
12 3 SynchronousVsAsyncVideo
•	MultiThreading: đến giờ chúng ta vẫn đang làm việc với console appilication và sử dụng thread để thực thi chương trình hay còn gọi là single thread. Tuy nhiên trong C# hay .NET Framework cho phép sử dụng multithreading(đa chương trình). Multithreading gọi là dạng thức của concurrency
•	Trong một máy tính thì CPU có rất nhiều core và sẽ là không hợp lý nếu chương trình làm rất nhiều việc trong khi chỉ sử dụng một core để làm việc trong khi core khác thì idle. Thường thì chúng ta có thể split chương trình thành nhiều tác vụ và tác vụ đấy có thể chạy trên nhiều thread khác nhau và thread đấy có thể chạy trên nhiều core khác nhau
•	Synchoronous Programming Model: (Lập trình đồng bộ) trong mô hình lập trình này thì một thread được assigned cho một task thì nó sẽ bắt đầu làm việc trên task đó và chỉ khi task đó hoàn thành thì thread đấy mới available và làm việc với task tiếp theo. Mô hình lập trình đồng bộ có thể sử dụng single thread hoặc multiple thread
•	Trong trường hợp sử dụng Single Thread: thì có nghĩa là nó chỉ sử dụng một thread để làm việc với những tác vụ chương trình
 
•	Lập trình đồng bộ có hỗ trợ làm việc trên multiple thread: có nghĩa là chúng ta sẽ sử dụng nhiều thread để làm việc song song với tác vụ trên máy
 
	Một thread chỉ làm việc với một tác vụ tại cùng một thời điểm, chỉ khi nó hoàn thành tác vụ đấy thì nó mới available cho tác vụ tiếp theo
•	Asynchronous Programming(lập trình bất đồng bộ): là một dạng thức của concurrency, trong lập trình bất đồng bộ một thread sẽ làm việc với nhiều tác vụ một lúc. Giả sử chúng ta có một thread và ta sẽ assigned một tác vụ cho nó thì thread đấy sẽ thực hiện tác vụ đấy và nó không cần đợi khi tác vụ đấy xong, có thể pause giữa chừng để nó làm việc với tác vụ thứ 2 và save current state của tác vụ một lại
  
	Trong lập trình bất đồng bộ một thread sẽ làm việc với multiple task tại cùng một thời điểm
12 4 ThreadClassVideo
 
•	Vòng đời của thread
 
•	Properties của thread
-	threadState: chúng ta có thể lấy ra trạng thái của thread hiện tại
-	Priority: sử dụng multi thread để get hoặc set độ ưu tiên đó 
-	CurrentContext: lấy được current context mà hiện thời thread đang chạy
-	IsAlive: trả về true nếu thread được start và nó chưa bị stop, còn trong trường hợp khác là false
-	IsBackground: get hoặc set xem thread có phải background hay không
12 5 ThreadClass2Video
•	C# có 2 loại thread: 
-	Foreground Thread: là cái tiếp tục chạy ngay cả khi chúng ta thoát chương trình và tiếp tục chạy
-	Background thread: là những thread bị terminate khi mà tất cả foreground thread bị đóng. Có nghĩa là ngay cả khi background thread chưa hoàn thành công việc nhưng mà foreground thread bị close rồi thì background thread cũng sẽ bị terminate. Thường thì chúng ta sẽ sử dụng Background thread cho tác vụ không quá quan trọng
-	Default khi tạo thread sẽ là foreground
•	Main Thread: thread được thực thi đầu tiên trong process thì sẽ được gọi là main thread
-	Trong một chương trình C# khi mà bắt đầu chạy thì main thread sẽ được tự động tạo ra và những thread được tạo ra bằng cách sử dụng thread class
•	Thread method:
-	Start(): start thread
-	Sleep(int): pause thread trong khoảng thời gian truyền vào(mili second)
-	Abort(): nó sẽ raises ra exception ThreadAbortException và nếu không sử dụng method reset abort() thì thread sẽ bị terminate
-	Join(): tất cả thread nằm sau phương thức join sẽ phải đợi cho đến khi thread đang gọi join hoàn thành thì nó mới được thực thi
12 7 TaskAsyncAwait Video
•	Lập trình bất đồng bộ là một dạng thức của concurrency và để thực thi concurrency thì lập trình bất đồng bộ cần sử dụng khái niệm futures hay là callback để tránh việc sử dụng thread không cần thiết
•	Future hoặc callback là trong lập trình bất đồng bộ có thể gọi tới method nhưng chúng ta không cần phải đợi đến khi method hoàn thành xong công việc thì mới thực thi tới method tiếp theo. Trong lập trình bất đồng bộ ta sẽ gọi tới method xong sẽ quên method đó đi, trong tương lai sau một khoảng thời gian method đó hoàn thành và trả lại giá trị thì lúc ta lại xử lý tiếp với method đó. Với việc trả lại giá trị thì trong .NET nó sẽ sử dụng Task hoặc Task<TResult>
•	Trong C# 5.0 nó có thể đơn giản hoá lập trình bất đồng bộ cho chúng ta bằng cách sử dụng 2 từ khoá Async và await
•	Từ khoá Async sẽ xác định một method của chúng ta là bất đồng bộ, ví dụ:
 
•	Asynchronous method sẽ trả lại 3 loại giá trị: 
-	Void: không trả lại gì cả và trong lập trình bất đồng bộ khi mà sử dung void có nghĩa là “fire và forget” gọi tới method đó và quên luôn(không cần biết là có hoàn thành hay không)
-	Task: không trả lại giá trị gì nhưng cho phép caller tức là thằng container gọi tới method biết rằng là method đó có finish hay không. Tức là trong tương lai method1 hoàn thành thì thằng caller biết là đã finish để xử lý tiếp
-	Task<T>: trả lại giá trị
•	Await: đợi, tức là gọi đến function Asynchronous bằng cách xử dụng await
 
9 0 FileStreamPathDirectory Video
•	I/O: trong .NET Framework nó cung cấp một namespace gọi là system.IO và namespace này chứa rất nhiều class cho phép chúng ta có thể đọc, ghi file hoặc data streams một cách dễ dàng
•	File là file chứa dữ liệu như file word, excel và save nó lại thì được gọi là file. Bên trong file là tập hợp byte và những byte này sẽ được lưu ở trên ổ đĩa, một file thì luôn được chỉ định tên và đường dẫn đến file đó và khi chúng ta viết một chương trình mở file đó ra cho nhiệm vụ đọc, ghi thì file đó sẽ biến thành stream
•	Stream(Luồng): nó đơn giản là sequence của byte, tức là tập hợp của các byte cho phép chúng ta có thể đọc, và ghi những byte đó vào trong ổ đĩa hoặc memory
•	Directory(thư mục): là container cho các file, file khi được tạo ra sẽ cần nơi lưu vào và nơi lưu đấy sẽ nằm trong thư mục
•	Path: cung cấp đường dẫn đến file hoặc thứ mục
9 1 Path Video
•	Một path chỉ định ra location vào file và directory của chúng ta, path đơn giản là một chuỗi, là một string instance. Path class sẽ cung cấp cho chúng ta method và properties để process trên string instances đó, và path class sẽ hoạt động cross-platform(chạy được với hệ thống windown và linux)
•	Path gồm có 2 loại là đường dẫn tuyệt đối và đường dẫn tương đối
-	C:\Windows\System32 là đường dẫn tuyệt đối
-	Windows\System32 là đường dẫn tương đối, nếu mình đang ở ổ C và copy đường dẫn và dán lại thì có thể đến đúng system32 tuy nhiên nếu đang ở C:\Program files thì paste thì sẽ không đi được đến system32 bởi vì trong Program file không có system32(phụ thuộc vào điểm đứng)
•	Phương thức cơ bản của path class(Method)
-	GetDirectoryName: trả lại tên của directory cho một path mà chúng ta truyền vào, ví dụ: 
 
-	GetFileName:trả lại cả tên file và phần mở rộng của file đó cho đường dẫn mà chúng ta truyền vào, ví dụ:
 
-	GetFileNameWithoutExtension: không trả lại phần extension mà chỉ trả lại file name
-	GetFullPath: trả lại đường dẫn tuyệt đối cho path mà ta truyền vào
-	GetExtension: chỉ trả lại extension mà không trả lại file name
-	9 3 DirectoryInfo Video
•	Directoryinfo class cũng là class của system.IO. Directory cung cấp cho chúng ta những method có thể tạo, move, có thể duyệt các directory hoặc subdirectories
•	Để tạo ra instance của directoryinfo class thì chúng ta sử dụng cú pháp sau
-	DirectoryInfo di = new DirectoryInfo(path)
•	Common properties Directory
-	Exists: cho biết thư mục đấy đã tồn tại hay chưa, nếu trong trường hợp chưa tồn tại sẽ trả lại là false và ngược lại
-	Name: trả lại tên của directory
-	Parent: trả lại parent directory của thư mục hiện tại
-	FullName: trả lại full path của directory
•	Common methods của directory
-	Create: tạo ra directory
-	Delete(Boolean): xoá đi directory hiện tại, trong trường hợp directory chứa thư mục con hoặc file truyền vào biến Boolean là false thì nó sẽ báo lỗi(không empty và không xoá được), còn nếu muốn xoá được thì phải trả về true
-	GetDirectories(String, SearchOption): trả lại danh sách những directory nằm trong directory hiện tại
-	GetFiles(String, SearchOption): trả lại danh sách các file nằm trong file directory
9 5 FileInfo Video
•	FileInfo class cũng là một class của namespace system.IO, nó sẽ cung cấp cho chúng ta những properties và những method cho việc tạo, moving, copy, delete và mở file
•	File là tập hợp của những byte và khi file được mở ra cho nhiệm vụ đọc hoặc ghi thì nó sẽ trở thành stream(luồng) và fileinfo class sẽ hỗ trợ tạo object thuộc dạng filestream 
•	Cú pháp tạo:
-	FileInfo fs = new FileInfo(path)
•	Common properties()
-	Name: trả lại tên file
-	FullName: trả lại full đường dẫn đến file đó
-	Length: trả lại size của byte theo file
-	Extension: trả lại phần mở rộng của file
-	IsReadOnly: cho biết file có readonly hay không
-	Exists: cho biết file có tồn tại hay không, trả về true là tồn tại và ngược lại
•	Common method
-	Open(FileMode, FileAccess): cho phép open một file để đọc, ghi hoặc là vừa đọc vừa ghi. Khi sử dụng method open thì sẽ truyền vào 2 parameter đó là fileMode và FileAccess>FileMode là sẽ chỉ định: muốn open hay muốn append vào cuối file, FileAccess: muốn đọc, ghi hay vừa đọc vừa ghi
-	Create(): tạo file trên đĩa
-	Moveto(string destFile): cho phép chuyển file tới vị trí mới và có thể đổi tên file
-	Delete(): xoá file
9 6 Stream Video
•	Stream class: file class là tập hợp các byte và khi mở file ra để đọc và ghi thì nó sẽ biến thành luồng của byte. Và system.IO nó có một abstract class gọi là stream class cung cấp cho ta những properties và những method cơ bản để có thể đọc ghi mảng của những byte này
 
•	Common properties(thuộc tính của luồng)
-	CanRead/CanWrite/CanSeek: hỗ trợ cho việc đọc, ghi hay việc tìm kiếm 
-	Length: trả về độ dài stream theo byte
-	Position: có thể get set vị trí con trỏ trong luồng đó
•	Common methods
-	Write(Byte[], Int32, Int32): luồng cho phép chúng ta có thể lưu một mảng những byte vào trong ổ đĩa và cung cấp thêm 2 parameter kiểu int32 là để chỉ vị trí của byte mà chúng ta muốn ghi vào và độ dài số lượng byte muốn ghi
-	Read(Byte[], Int32, Int32): cho phép đọc một mảng các byte và cung cấp đọc từ vị trí nào tuỳ theo số lượng byte muốn đọc
-	Seek(Int64, SeekOrigin): cho phép set lại position trong luồng
9 7 FileStream Video
•	FileStream: khi mở file cho nhiệm vụ đọc và ghi thì file đó sẽ trở thành stream và filestream là một trong những luồng. FileStream sẽ support tác vụ đọc và ghi những byte từ file vật lý dù file đó là file txt, .exe, .jpg.v.v.
•	File stream sẽ hỗ trợ đọc và ghi đồng bộ và bất đồng bộ
•	Common properties
-	CanRead, CanWrite: cho phép stream hiện tại cho phép đọc hay không
-	Length: trả về kích cỡ dưới dạng byte của một stream
-	IsAsync: file stream đấy được mở ở dạng đồng bộ hay bất đồng bộ
•	Common method
-	Write(Byte[], Int32, Int32): ghi block hoặc byte vào trong ổ đĩa
-	Read(Byte[], Int32, Int32): cho phép đọc block hoặc byte từ luồng và ghi dữ liệu đấy vào buffer
9 9 StreamReaderStreamWriter Video
•	StreamReader/StreamWriter class: .NET Framework cung cấp 2 abstract class là TextReader và TextWriter cho phép ta có thể đọc và ghi text file, StreamReader/StreamWriter chính là implementation của TextReader/Writer
 
•	Cú pháp:
-	StreamReader sr = new StreamReader(path);
-	StreamWriter sr = new StreamWriter (path);
•	Common Methods
StreamReader
-	Read(): đọc các kí tự trong stream và trả về vị trí của kí tự đó, trả lại kiểu Int32. Còn khi đã đọc hết luồng thì trả về -1
-	ReadLine(): trả về dòng tiếp theo của stream đó, và trả lại null nếu đã đọc hết
-	Peak(): trả lại kiểu số cho kí tự tiếp theo cần đọc và sẽ trả lại -1 nếu hết cái đọc
StreamWriter
-	Write(string): cho phép write string vào trong stream và từ stream đó tự động sắp xếp vào trong phisical
-	WriteLine(string): Viết một chuỗi vào trong Luồng và sẽ terminate bởi dấu xuống dòng




