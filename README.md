FirstProgram C#
<h2>CourseIntroduction</h2>
![image](https://user-images.githubusercontent.com/94780400/179254303-91c84885-3eae-428d-88bc-9b0d334fe83d.png)
Mục tiêu khoá học:
![image](https://user-images.githubusercontent.com/94780400/179254328-1fab18fd-bf7a-4713-b82e-ff2868605790.png)
C# features
![image](https://user-images.githubusercontent.com/94780400/179254360-974fcd5c-cc17-44eb-98d9-4ead8931e47a.png)
•	.NET Framework là programing framework cho phép chúng ta xây dựng và triển khai ứng dụng được viết bằng .NET
•	Sử dụng .NET Framework có thể giảm thiểu thời gian để viết và triển khai ứng dụng phần mềm
•	.NET Framework có 2 phần chính
-	Common language runtime(CLR): được gọi là execution engine chạy trên c#
-	Framework class library(FCL): là một thư viện của class, interface, value type cho phép tương tác với hệ thống. VD:system.io
![image](https://user-images.githubusercontent.com/94780400/179254398-832f2f27-6ffc-40cf-b71e-1e45ab39c8d0.png)
![image](https://user-images.githubusercontent.com/94780400/179254406-7e12a396-e1d0-4361-a970-13dfd3a0a899.png)
•	C# codeSnippet là đoạn code dựng sẵn, bạn có thể quickly insert vào trong source code
![image](https://user-images.githubusercontent.com/94780400/179254633-be038d90-91a8-4781-ab02-c3d8976c74b6.png)
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



