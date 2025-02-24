Lập trình giống với việc khám phá một ngôi nhà tối, trong đó mỗi phòng tượng trưng cho một phần của hệ thống hoặc một tính năng mới.

Viết code mà không có test giống như đi trong bóng tối 

- Bạn không biết chắc mình đang ở đâu, có thể vấp phải chướng ngại vật (bug, thiết kế kém).

Viết test giống như bật đèn
- Nó giúp bạn thấy rõ vấn đề, xác định các lỗi sớm và tránh mắc sai lầm trong thiết kế.
- Refactoring (cải thiện thiết kế mà không thay đổi hành vi) giúp bạn sắp xếp lại đồ đạc trong phòng một cách hợp lý, giúp mọi thứ gọn gàng và dễ di chuyển hơn.
- Sau khi dọn xong một phòng, bạn tiếp tục khám phá phòng tiếp theo, tức là bạn có thể tiếp tục phát triển hệ thống mà không lo lắng về những vấn đề ở phần cũ.
 
# Một số quy tắc cơ bản

TDD dựa trên hai quy tắc cốt lõi:
- Không viết một dòng code nào nếu chưa có một automated test bị fail trước.
- Loại bỏ sự trùng lặp trong code.

Mặc dù chỉ có hai quy tắc đơn giản, nhưng chúng tạo ra những ảnh hưởng sâu rộng đến cách lập trình cá nhân và làm việc nhóm.

- Thiết kế phải được organically:
    - Không thiết kế quá phức tạp ngay từ đầu.
    - Chỉ thêm tính năng khi có nhu cầu thực tế từ test.
    - Nhận phản hồi từ code chạy được, cải tiến dần dần.
=> *Thay vì cố gắng thiết kế ngay một hệ thống hoàn chỉnh, ta phát triển từng bước nhỏ, viết test trước và chỉ mở rộng khi cần thiết*.
- Lập trình viên phải tự viết test của mình: nếu bạn cần test ngay lập tức, bạn không thể chờ ai đó viết hộ, vì quy trình TDD yêu cầu test có trước. 

    => *Điều này giúp lập trình viên hiểu rõ hơn về yêu cầu của tính năng trước khi code*.

- Môi trường phát triển phải hỗ trợ phản hồi nhanh:
    - Mỗi thay đổi nhỏ trong code cần được phản hồi ngay, giúp bạn duy trì dòng chảy phát triển (flow).
    => *Liên quan đến công cụ build test, IDE, CI/CD*.

- Thiết kế phải gồm nhiều thành phần có *loosely coupled, highly cohesive*.

Trong Test-Driven Development (TDD), có một chu kỳ gồm ba bước liên tục được gọi là Red / Green / Refactor. Mỗi bước có một mục đích cụ thể giúp đảm bảo code đúng, dễ hiểu và có thiết kế tốt:
- **Red**: Viết một test bị fail trước, thậm chí có thể không complie được ngay từ đầu.
- **Green**: Viết code tối thiểu để test pass, thậm trí code ban đầu có thể xấu.
- **Refactor**:  Cải thiện code mà vẫn giữ test pass, dọn dẹp code, loại bỏ sự trùng lặp mà không làm test fail.

Red/green/refactor => câu thần chú của TDDs.

Test-Driven Development không phải là gánh nặng, mà là một công cụ để lập trình viên làm việc thông minh hơn và hiệu quả hơn.
- Nếu code được kiểm tra liên tục bằng test tự động, số lượng bug sẽ giảm mạnh, QA không cần dành quá nhiều thời gian tìm và sửa lỗi, mà có thể chủ động cải thiện quy trình.
- Nếu mỗi thay đổi được kiểm tra ngay lập tức qua test tự động, ta tránh được các bất ngờ lớn về sau, Quản lý dự án có thể tự tin hơn trong việc ước tính thời gian và nguồn lực.
- Khi mỗi thay đổi đều đi kèm với một test cụ thể, ta biết chính xác phần nào của hệ thống đang thay đổi. Các cuộc thảo luận kỹ thuật trở nên dễ hiểu hơn vì mọi người đều có chung ngữ cảnh. Lập trình viên có thể làm việc cùng nhau từng phút từng giây, thay vì chỉ họp mỗi ngày hoặc mỗi tuần.
- Nếu ta luôn giữ tất cả test pass, có nghĩa là phần mềm luôn sẵn sàng để release. Doanh nghiệp có thể tạo ra giá trị mới cho khách hàng hàng ngày, thay vì chờ đợi nhiều tháng để có một bản release lớn.

## Fear

Trong lập trình, sợ hãi không phải là điều xấu. Nó là dấu hiệu cho thấy ta đang đối mặt với một vấn đề khó, một tình huống mà ta chưa thể thấy trước toàn bộ giải pháp.

Nhưng vấn đề là nỗi sợ có thể gây ra những phản ứng tiêu cực:

- Làm bạn do dự → Chần chừ, không dám thay đổi code.
- Làm bạn cáu gắt → Dễ bực bội khi mọi thứ không hoạt động như mong đợi.
- Làm bạn ít giao tiếp hơn → Ngại thảo luận, dẫn đến hiểu lầm trong nhóm.
- Làm bạn né tránh phản hồi → Không muốn kiểm tra code, sợ thấy lỗi.

TDD giúp bạn vượt qua nỗi sợ thế nào?
Thay vì để nỗi sợ kiểm soát mình, TDD hướng bạn đến một quy trình chủ động:

✅ Thay vì do dự → Bắt đầu học từ những ví dụ cụ thể
→ Viết một bài test nhỏ giúp bạn xác định vấn đề rõ ràng hơn.

✅ Thay vì né tránh giao tiếp → Giao tiếp rõ ràng hơn
→ Test cases là một cách mô tả chính xác yêu cầu mà không cần giải thích dài dòng.

✅ Thay vì tránh phản hồi → Chủ động tìm kiếm phản hồi
→ Mỗi lần chạy test là một phản hồi tức thì về chất lượng code.

✅ (Còn vấn đề cáu gắt thì bạn phải tự giải quyết 😆)

## Kết luận
Bạn không cần phải là thiên tài hay có ngân sách khổng lồ để tạo ra những khoảnh khắc kỳ diệu. Phương pháp và cơ hội là thứ bạn có thể kiểm soát.

Nếu bạn muốn đạt được những đột phá trong công việc của mình, hãy thực hành phát triển theo hướng kiểm thử (TDD):

✅ Luôn viết một kiểm thử tự động thất bại trước khi viết bất kỳ mã nào

✅ Luôn loại bỏ sự trùng lặp trong mã nguồn

👉 Hai quy tắc đơn giản này có thể giúp bạn làm việc gần với tiềm năng của mình nhất!

# Section I: Money Example

Hãy thử thực hành viết kiểm thử theo các bước sau:

1. Thêm nhanh một kiểm thử mới
2. Chạy tất cả kiểm thử và xác nhận kiểm thử mới bị lỗi
3. Thực hiện một thay đổi nhỏ để kiểm thử vượt qua
4. Chạy lại tất cả kiểm thử và đảm bảo chúng đều thành công
5. Refactor để loại bỏ sự trùng lặp

Những điều có thể khiến bạn bất ngờ
- Mỗi kiểm thử chỉ kiểm tra một phần nhỏ của chức năng
- Mã thay đổi có thể rất nhỏ và thậm chí trông khá xấu xí ban đầu
- Chạy kiểm thử rất thường xuyên – gần như sau mỗi thay đổi nhỏ
- Refactoring bao gồm rất nhiều bước nhỏ li ti

Điểm cốt lõi của TDD không phải là viết mã hoàn hảo ngay từ đầu, mà là phát triển mã một cách có kiểm soát, từng bước nhỏ, với sự hỗ trợ liên tục của kiểm thử tự động.

## Ví dụ
Chúng ta bắt đầu với ý tưởng của Ward tại WyCash về đối tượng tiền đa tiền tệ. Ban đầu, báo cáo chỉ bao gồm số lượng cổ phiếu và giá mà không có thông tin tiền tệ:

```code
Instrument    Shares    Price    Total
IBM           1000      25       25000
GE            400       100      40000
Total: 75000

```

Khi báo cáo cần hỗ trợ đa tiền tệ, chúng ta bổ sung thông tin đơn vị tiền tệ:

```code
Instrument    Shares    Price    Total
IBM           1000      25 USD   25000 USD
Novartis      400       150 CHF  40000 CHF
Total: 75000 USD
```

Và ta cũng cần một bảng tỷ giá chuyển đổi, ví dụ:
```code
From    To      Rate
CHF     USD     1.5
```

Để đảm bảo hệ thống xử lý đúng báo cáo đa tiền tệ, ta cần code phải có những hành vi sau:

- Cộng số tiền ở các đơn vị khác nhau: Phải có khả năng cộng các số tiền từ hai loại tiền tệ khác nhau và chuyển đổi kết quả dựa trên bảng tỷ giá.
- Nhân số tiền với số lượng: Phải có khả năng nhân một số tiền (giá mỗi cổ phiếu) với số lượng cổ phiếu để tính ra tổng số tiền.

Để thực hiện bài toán này, chúng ta sẽ tạo todo list để focus vào những cái cần làm, và biết được khi nào chúng ta hoàn thành:

```code
To do:
$5 + 10 CHF = $10 if CHF:USD is 2:1
$5 * 2 = $10
```

Câu hỏi đặt ra là: "Chúng ta cần đối tượng nào trước?"

Nhưng đây là một câu hỏi đánh lừa, vì trong Test-Driven Development (TDD), ta không bắt đầu bằng việc thiết kế đối tượng ngay. Thay vào đó, ta bắt đầu bằng viết một bài kiểm thử trước.

Vậy kiểm thử nào nên viết trước?
Nhìn vào danh sách to-do:

Hãy nhớ *Start small or not at all* và chúng ta thấy rằng:
$5 + 10 CHF = $10 nếu tỷ giá CHF:USD là 2:1 → Đây là một phép tính liên quan đến nhiều loại tiền tệ và có thể phức tạp.

$5 * 2 = $10 → Đây là một phép nhân đơn giản hơn.
👉 Vì nguyên tắc trong TDD là "bắt đầu với bước nhỏ nhất có thể", ta sẽ chọn kiểm thử phép nhân trước.

=> Trong TDD, thay vì cố gắng thiết kế một API "thực tế" và phức tạp ngay từ đầu, ta nên bắt đầu với một API đẹp, dễ hiểu, dễ dùng nhất, rồi điều chỉnh dần khi phát triển.

Ở đây là ví dụ của multiplication:

```csharp
    [Fact]
    public void TestMultiplication()
    {
        Dollar five = new(5);
        five.Times(2);
        Assert.Equal(10, five.Amount);
    }
```

Chúng ta có thể thấy có một số điểm chưa tốt ở đây:
- Dùng public fields → Không tuân theo nguyên tắc đóng gói (encapsulation).
- Có thể gây side-effects → Code có thể làm thay đổi trạng thái ngoài dự kiến.
- Dùng số nguyên (int) để biểu diễn tiền → Có thể gây lỗi làm tròn.

Nhưng chúng ta sẽ làm từng bước nhỏ, mặc dù code có thể sẽ cẩu thả nhưng chúng ta hãy ghi lại sự cẩu thả đó, và tiếp tục. Chúng ta có một bài kiểm thử thất bại và muốn nó chạy thành công càng nhanh càng tốt.

Chúng ta sẽ sửa lại to-do:

```code
To do:
$5 + 10 CHF = $10 if CHF:USD is 2:1
$5 * 2 = $10
Make “amount” private
Dollar side-effects?
Money rounding?
```

Nhưng trước hết, bài test trên vừa được viết nhưng chưa thể biên dịch được do thiếu các thành phần cơ bản trong code:

- Chưa có class Dollar → Cần tạo một class có tên Dollar.
- Chưa có constructor → Cần tạo constructor cho Dollar(int amount).
- Chưa có phương thức Times(int) → Cần tạo một method Times(int multiplier).
- Chưa có field amount → Cần khai báo một biến amount trong class Dollar.

Vì vậy, cần thêm tối thiểu các thành phần để code biên dịch được, dù nó chưa chạy đúng, chúng ta sẽ làm từng bước một

- Tạo class Dollar
- Bây giờ sẽ cần contructor nhưng ko làm bất cứ điều gì, chỉ để biên dịch được đã.
```csharp
Dollar
    Dollar(int amount) {
    }
```
- Tương tự, tạo method Times
```csharp
Dollar
    void Times(int multiplier) {
    }
```

- Cuối cùng thêm field Amount:
```csharp
Dollar
    int amount;
```

Bây giờ, chạy test và xem nó thất bại → Mục tiêu của bước này không phải làm đúng, mà là để test có thể chạy.

![alt text](image.png)

Chúng ta nhìn thấy màu đỏ không ưa thích =)). Bởi kết quả mong đợi là 10 nhưng nó lại nhận về 0.

Nhưng đây không phải điều xấu. Bởi vì:

✅ **Lỗi là tiến bộ → Vì nó giúp ta thấy rõ điều gì chưa đúng**.

✅ **Có lỗi nghĩa là ta đã có thước đo cụ thể → Chúng ta biết cần sửa gì**.

Điều đó tốt hơn là chỉ mơ hồ biết rằng chúng ta đang thất bại.

Chúng ta đã chuyển đổi vấn đề phức tạp thành vấn đề nhỏ. Ban đầu, bài toán rất rộng: “Làm sao để hỗ trợ đa tiền tệ?”, nhưng bây giờ, vấn đề đã rõ ràng hơn: “Làm sao để test này chạy đúng?”

Từ đó vấn đề sẽ đơn giản hơn, giảm nỗi sợ hãi khi lập trình.

Chúng ta chưa cần code đẹp, tối ưu, hay “đúng chuẩn” ngay. Ưu tiên hàng đầu: Viết code đơn giản nhất có thể để test pass. Sau khi test pass, chúng ta sẽ refactor (cải tiến code).

Sau đây là thay đổi nhỏ nhất mà tôi có thể tưởng tượng có thể khiến bài kiểm tra của chúng tôi vượt qua:

```csharp
Dollar
    int Amount= 10;
```

Và bài kiểm tra của chúng ta đã có màu xanh hy vọng :D

![alt text](image-1.png)


Chúng ta đã làm cho test pass! 🟢 Nhưng đừng vội mừng! Code hiện tại chỉ pass được đúng một bộ dữ liệu (ví dụ: 5 * 2 = 10). Nhưng nếu thử với giá trị khác (6 * 2 hoặc 5 * 3), code sẽ thất bại ngay lập tức => Ta cần tổng quát hóa (generalize) để xử lý mọi trường hợp.

TDD không chỉ là viết test và làm cho test pass → Cần có bước refactor!

🔄 Chu trình TDD đúng chuẩn:

1. Viết một test nhỏ

2. Chạy test → Phải thất bại (Red Bar) ❌

3. Sửa code tối thiểu để test pass (Green Bar) ✅

4. Chạy lại test để kiểm tra

5. Refactor (cải tiến code, loại bỏ trùng lặp, tổng quát hóa)


```

Vấn đề trong code và test hiện tại không phải là do sự lặp lại (duplication) mà là do sự phụ thuộc giữa chúng.

Code và test đang bị ràng buộc lẫn nhau đến mức khi bạn thay đổi code, bạn cũng phải thay đổi test (và ngược lại). Mục tiêu của chúng ta là có thể viết những bài test mới mà “hợp lý” theo cách chúng ta mong muốn, mà không buộc phải thay đổi code đã có.

Sự trùng lặp thường xuất hiện khi cùng một đoạn logic hay biểu thức điều kiện xuất hiện nhiều nơi trong code. Điều này là dấu hiệu cho thấy code của bạn đang phụ thuộc vào cách bạn đã triển khai logic đó.

Sự trùng lặp cũng có thể xuất hiện ở dạng dữ liệu, chẳng hạn như khi sử dụng “magic numbers”. Việc sử dụng hằng số ký hiệu (symbolic constants) giúp loại bỏ phụ thuộc vào các giá trị cụ thể đó. Khi đã dùng hằng số, bạn có thể thay đổi giá trị của chúng mà không cần thay đổi code.

Khác với các vấn đề khác: Trong nhiều trường hợp, việc loại bỏ triệu chứng chỉ làm cho vấn đề xuất hiện ở nơi khác dưới dạng nghiêm trọng hơn.

Trong lập trình, loại bỏ sự trùng lặp không chỉ loại bỏ “triệu chứng” mà còn loại bỏ nguồn gốc của sự phụ thuộc.

Trong TDD, quy tắc thứ hai (“luôn loại bỏ sự trùng lặp”) giúp đảm bảo rằng khi bạn chuyển sang bài test kế tiếp, chỉ cần thực hiện một thay đổi duy nhất để làm cho bài test đó pass. Điều này làm cho quá trình phát triển trở nên rõ ràng và có kiểm soát hơn.
```

Nhưng ở đây sự trùng lặp không nằm giữa hai đoạn code khác nhau, mà nằm giữa dữ liệu được sử dụng trong bài kiểm thử (test) và dữ liệu cứng (hard-coded) trong code.

Thông thường, bạn thấy sự trùng lặp khi cùng một đoạn logic hoặc biểu thức xuất hiện nhiều nơi trong code.

Ở đây, sự trùng lặp là giữa giá trị "5" và "2" được dùng trong bài kiểm thử và giá trị cứng được viết trực tiếp trong code, ví dụ:

```csharp
int amount = 5 * 2;
```

Trong trường hợp này, số 5 được truyền cho constructor và số 2 được dùng làm tham số nhân trong phương thức Times(). Cả hai giá trị này xuất hiện ở hai nơi khác nhau, làm cho code trở nên phụ thuộc vào dữ liệu cứng và gây khó khăn khi cần thay đổi.

Quá trình loại bỏ sự trùng lặp

1. Phát hiện sự trùng lặp:
- Nhận ra rằng "10" (kết quả của 5 * 2) đã được tính toán sẵn trong đầu, nên giá trị 5 và 2 lại xuất hiện trong code.

2. Chuyển đổi cách thiết lập giá trị:
- Thay vì tính toán "10" trực tiếp trong phương thức times(), ta chuyển việc lấy giá trị "5" từ đối số của constructor và lưu nó vào biến amount:

```csharp
    public Dollar(int amount)
    {
         Amount = amount;
    }
```

3. Sử dụng tham số thay vì hằng số
Trong phương thức times(), thay vì sử dụng hằng số "2", ta dùng tham số multiplier:
```csharp
    public void Times(int multiplier)
    {
        Amount *= multiplier;
    }
```
4. Giờ đây, giá trị "5" xuất hiện duy nhất ở nơi được truyền vào constructor, và số nhân được cung cấp thông qua tham số. Điều này loại bỏ sự trùng lặp giữa dữ liệu trong test và code.

=> TDD không chỉ là làm cho bài test pass, mà còn là cải tiến (refactor) code để loại bỏ những sự phụ thuộc không cần thiết và loại bỏ sự trùng lặp.

=> Khi không có sự trùng lặp, ta có thể thêm bài test mới mà không phải thay đổi code đã có, giúp giảm rủi ro và làm cho hệ thống dễ bảo trì hơn.

Bây giờ to do chỉ còn:

```
To do:
$5 + 10 CHF = $10 if CHF:USD is 2:1
$5 * 2 = $10 (Done)
Make “amount” private
Dollar side-effects?
Money rounding?
```

## Degenerate Objects

 Trước đó, khi thực hiện phép nhân (times) trên đối tượng Dollar, đối tượng đó thay đổi giá trị của nó, nhưng điều này lại không phải là cách thiết kế mà chúng ta mong muốn.

 Ví dụ ban đầu bạn muốn viết test như sau:

 ```csharp
     [Fact]
    public void TestMultiplication()
    {
        Dollar five = new(5);
        five.Times(2);
        Assert.Equal(10, five.Amount);

        five.Times(3);
        Assert.Equal(15, five.Amount);
    }
 ```

 Ở đây, sau khi gọi Times(2), đối tượng five đã biến thành 10, và sau đó Times(3) sẽ tính 10 * 3 = 30, chứ không phải giữ giá trị ban đầu là 5 và nhân với 3 để ra 15. Điều này cho thấy việc gọi Times() làm thay đổi trạng thái của đối tượng, gây ra những vấn đề khi muốn sử dụng đối tượng gốc nhiều lần.

 Để giải quyết vấn đề, ta thay đổi thiết kế sao cho phương thức Times() không làm thay đổi đối tượng ban đầu mà thay vào đó trả về một đối tượng mới với giá trị đã được nhân. Test cũng cần được điều chỉnh tương ứng:

Ở đây, đối tượng five luôn giữ nguyên giá trị ban đầu là 5, và phương thức Times() trả về một đối tượng mới chứa kết quả nhân.

```csharp
    [Fact]
    public void TestMultiplication()
    {
        Dollar five = new(5);
        var product = five.Times(2);
        Assert.Equal(10, product.Amount);

        product = five.Times(3);
        Assert.Equal(15, product.Amount);
    }
```
Ok, giờ chúng ta sẽ sửa đổi phương thức Times() trong code.

Ban đầu, bạn có thể viết stub của phương thức như sau để code biên dịch:

```csharp
    public Dollar Times(int multiplier)
    {
        Amount *= multiplier;
        return null;
    }
```

Vậy đã biên dịch thành công, nhưng sau đó, để làm cho bài test chạy được, bạn thay đổi thành:

```csharp
    public Dollar Times(int multiplier)
    {
        return new Dollar(Amount * multiplier);
    }
```

Điều này có nghĩa là thay vì thay đổi giá trị của đối tượng hiện tại, phương thức sẽ tạo ra một đối tượng Dollar mới với giá trị được nhân.

Sau khi thay đổi, chúng ta có thể "gạch bỏ" một mục trong danh sách việc cần làm (to-do list) và tiếp tục xử lý các vấn đề khác như side-effects, làm cho biến amount trở nên private, xử lý làm tròn tiền, v.v.

```
To do:
$5 + 10 CHF = $10 if CHF:USD is 2:1
~~$5 * 2 = $10~~
Make “amount” private
~~Dollar side-effects?~~
Money rounding?
```

Hai trong số ba chiến lược chính để nhanh chóng đưa bài test sang trạng thái "green" (tất cả bài test đều pass) trong quá trình TDD, cụ thể:

- Fake It – Đây là chiến lược bạn trả về một hằng số (constant) thay vì tính toán thực sự. Sau đó, từ từ thay thế hằng số đó bằng biến (variables) cho đến khi có được code thực sự hoàn chỉnh.

- Obvious Implementation – Đây là chiến lược bạn gõ trực tiếp code triển khai đúng, dựa trên những gì bạn nghĩ là “rõ ràng” và đúng đắn. Khi mọi thứ suôn sẻ và bạn biết chính xác cần gõ gì, bạn sẽ liên tục gõ “obvious implementation” và chạy bài test để đảm bảo máy tính vẫn hiểu theo cách mà bạn mong đợi.

Trong thực tế, khi làm việc theo TDD, họ thường chuyển đổi giữa hai chế độ này. Khi mọi thứ ổn và bạn tự tin về những gì sẽ gõ, bạn dùng Obvious Implementation; nhưng nếu bất ngờ gặp lỗi (một thanh đỏ hiện ra), bạn quay lại sử dụng chiến lược Fake It để tạm thời “đi qua” lỗi đó, sau đó refactor code cho đúng. 

Một chiến lược thứ ba, gọi là Triangulation, mà sẽ được trình bày trong chương tiếp theo.

TÓm lại:
- Biến một phàn nàn về thiết kế (ví dụ, side effects) thành một bài test thất bại.
- Làm cho code biên dịch nhanh chóng bằng cách sử dụng các stub (code tạm) tối thiểu.
- Viết code sao cho bài test chạy thành công bằng cách gõ code “điển hình” (obvious implementation) hoặc “giả lập” (fake it) cho đến khi đạt được kết quả đúng.

Việc chuyển hóa cảm nhận của mình (ví dụ, sự ghê tởm với side effects) thành một bài test cụ thể (nhân cùng một Dollar hai lần) là một chủ đề chung trong TDD. Khi bạn có khả năng chuyển hóa những đánh giá thẩm mỹ của mình thành các bài test, các cuộc thảo luận về thiết kế sẽ trở nên ý nghĩa hơn. Thay vì tranh cãi một cách mơ hồ, bạn có thể bàn luận về các trường hợp cụ thể của bài test để đưa ra quyết định đúng đắn về hành vi của hệ thống.

Nói một cách khác, dù bạn có thể bàn luận về “sự thật” hay “vẻ đẹp” trong code suốt buổi tối với bạn bè, khi lập trình bạn cần rút gọn các cuộc thảo luận đó thành các trường hợp cụ thể (test cases) để hướng tới một thiết kế tốt và dễ bảo trì.

## Equality for All

Khi hai biến tham chiếu cùng một đối tượng trong bộ nhớ, thay đổi ở một biến có thể làm thay đổi giá trị của biến kia một cách không mong muốn. 
→ Giải pháp: Dùng Value Object. Khi một giá trị cần thay đổi, ta tạo một đối tượng mới thay vì thay đổi giá trị của đối tượng cũ.

 Value Object lột kiểu đối tượng không thể thay đổi (immutable). Một khi được tạo ra, giá trị của nó không thể bị thay đổi.

 Ví dụ: Nếu bạn có một đối tượng Dollar đại diện cho số tiền $5, thì nó mãi mãi là $5. Nếu bạn cần $7, bạn phải tạo một đối tượng mới thay vì thay đổi giá trị của đối tượng hiện tại.

 ```csharp
Dollar five = new Dollar(5);
Dollar seven = new Dollar(7); // Không thay đổi five, tạo một đối tượng mới
 ```

Và một 5 Dollar sẽ tương ứng bằng với một 5 Dollar khác, do đó to do chúng ta sẽ được thêm

```
To do:
$5 + 10 CHF = $10 if CHF:USD is 2:1
(Done) $5 * 2 = $10
Make “amount” private
(Done) Dollar side-effects?
Money rounding?
Equals()
```

Khi một đối tượng được dùng làm key trong một HashMap, HashSet hoặc HashTable, chúng ta sử dụng HashCode() để nhanh chóng tìm kiếm bucket (vị trí lưu trữ) trong bảng băm.

Do đó to do sẽ thêm:

```
To do:
$5 + 10 CHF = $10 if CHF:USD is 2:1
(Done) $5 * 2 = $10
Make “amount” private
(Done) Dollar side-effects?
Money rounding?
Equals()
HashCode()
```

Khi đó chúng ta viết test case như sau:

```csharp
    [Fact]
    public void TestEqual()
    {
        Assert.True(new Dollar(5).Equals(new Dollar(5)));
    }
```

Và fake it đơn giản chỉ tra về true:

```csharp
    public override bool Equals(object? obj)
    {
        return true;
    }
```

Khi ta nói “true” thì thực ra có nghĩa là “5 == 5”, hay trong trường hợp của Dollar, “amount == 5” và cuối cùng là “amount == dollar.amount”.

Triangulation trong thực tế là kỹ thuật đo khoảng cách và hướng của tín hiệu dựa trên các đo đạc từ hai trạm thu khác nhau.
Trong TDD, “triangulation” có nghĩa là chỉ tổng quát hóa code khi có hai ví dụ trở lên. Khi có thêm ví dụ, chúng ta bắt buộc phải viết code tổng quát hơn để xử lý tất cả các trường hợp.

Ví dụ về Triangulation trong việc so sánh Dollar:

Ban đầu, ta viết một bài test kiểm tra rằng Dollar(5) bằng Dollar(5):

```csharp
Assert.True(new Dollar(5).Equals(new Dollar(5)));
```

Để ép buộc tổng quát hóa, ta cần thêm bài test thứ hai, ví dụ là Dollar(5) không bằng Dollar(6):

```csharp
    [Fact]
    public void TestEqual()
    {
        Assert.True(new Dollar(5).Equals(new Dollar(5)));
        Assert.False(new Dollar(5).Equals(new Dollar(6)));
    }
```

Khi có thêm test case, kết quả sẽ false vì fake giá trị trước đó không bao quát được hết các trường hợp, ta sửa lại hàm Equals.


```csharp
    public override bool Equals(object? obj)
    {
        Dollar dollar = (Dollar)obj;
        return Amount == dollar.Amount;
    }
```

Nếu bạn đã thấy rõ cách tạo ra một giải pháp tổng quát và có thể loại bỏ sự trùng lặp giữa code và test, bạn có thể tiến hành refactor ngay lập tức. Tuy nhiên, khi bạn không chắc chắn về cách tiếp cận hoặc thiết kế chưa rõ ràng, việc viết thêm một test mới (hay còn gọi là triangulation) giúp bạn “xoay” vấn đề từ một góc nhìn khác, phát hiện ra những khía cạnh mà trước đó có thể chưa nghĩ đến.

Đây là những khía cạnh khác nhau mà giải pháp của bạn cần phải hỗ trợ. Ví dụ, khi triển khai phương thức so sánh (equals), bạn cần xem xét so sánh với null, so sánh với các đối tượng thuộc kiểu khác… Việc thêm các bài kiểm thử cho những trường hợp này giúp đảm bảo rằng thiết kế của bạn đủ mạnh và tổng quát để xử lý đa dạng tình huống.

```
To do:
$5 + 10 CHF = $10 if CHF:USD is 2:1
(done) $5 * 2 = $10
Make “amount” private
(done) Dollar side-effects?
Money rounding?
(done) Equals()
HashCode()
Equal null
Equal object
```

Tóm tắt lại phần trên:

- Nhận diện yêu cầu: Nhận ra mẫu thiết kế (ở đây là Value Object) gợi ý ra một phép toán nào đó cần phải được hỗ trợ.
- Viết test: Đầu tiên, bạn viết các bài kiểm thử cho phép toán đó.
- Cài đặt đơn giản: Sau đó, bạn cài đặt giải pháp một cách đơn giản dựa trên các test ban đầu.
- Triangulation: Thay vì refactor ngay lập tức, bạn tiếp tục viết thêm các test để khám phá các trường hợp khác, giúp bạn nhận diện và gộp lại các trường hợp tương đồng.
- Refactor: Cuối cùng, bạn refactor để cải thiện thiết kế, như việc chuyển thuộc tính “amount” thành private, bởi giờ đây bạn đã có đủ test để bảo vệ code.

## Privacy

Hàm Times hiện tại đang trả về một Dollar nhưng test case hiện tại chúng ta như sau:

```csharp
    [Fact]
    public void TestMultiplication()
    {
        Dollar five = new(5);
        var product = five.Times(2);
        Assert.Equal(10, product.Amount);

        product = five.Times(3);
        Assert.Equal(15, product.Amount);
    }
```

Chúng ta đã có phương thức equals trong lớp Dollar, vậy tại sao không dùng nó để so sánh trực tiếp các đối tượng Dollar thay vì so sánh giá trị amount? Điều này làm cho bài kiểm thử trở nên ý nghĩa hơn, thể hiện rõ rằng: "Kết quả của five.Times(2) là một Dollar có giá trị 10."

```csharp
    [Fact]
    public void TestMultiplication()
    {
        Dollar five = new(5); 
        Assert.Equal(new Dollar(10), five.Times(2)); 
        Assert.Equal(new Dollar(15), five.Times(3));
    }
```

Cả hai câu lệnh assert giờ đây đều so sánh các đối tượng Dollar. Bài kiểm thử trở nên nhất quán và rõ ràng hơn, nói lên rằng việc nhân một Dollar với một hệ số sẽ tạo ra một Dollar khác có giá trị đúng như mong đợi.

Trong bài kiểm thử ban đầu, chúng ta truy cập trực tiếp product.Amount. Nhưng giờ đây, khi đã dùng Equals để so sánh các đối tượng Dollar, bài kiểm thử không còn cần truy cập Amount nữa. Điều này cho phép chúng ta đặt Amount thành private trong lớp Dollar:

```csharp
public class Dollar
{
    private int Amount;
}
```

Khi đó danh sách To do sẽ là:

```
To do:
    $5 + 10 CHF = $10 if CHF:USD is 2:1
    x $5 * 2 = $10
    x Make “amount” private
    x Dollar side-effects?
    Money rounding?
    x Equals()
    HashCode()
    Equal null
    Equal object
```

Việc tái cấu trúc này có một rủi ro: vì TestMultiplication giờ phụ thuộc vào Equals, nếu Equals được viết sai (ví dụ: luôn trả về true), thì lỗi trong Times có thể không bị phát hiện.  

Phương pháp TDD không nhằm loại bỏ hoàn toàn mọi rủi ro hay đảm bảo mã không bao giờ có lỗi. Thay vào đó, nó chấp nhận rằng một số lỗi có thể xảy ra và sử dụng các chiến lược để giảm thiểu chúng:

Biểu diễn kép:
Mọi chức năng trong TDD được thể hiện theo hai cách:
1. Mã triển khai: Ví dụ, phương thức Times thực hiện phép nhân.
2. Bài kiểm thử: Ví dụ, TestMultiplication xác minh kết quả của Times.
Sự kiểm tra chéo này giúp tăng khả năng phát hiện lỗi sớm.

Nếu một lỗi lọt qua bài kiểm thử, TDD khuyến khích chúng ta học từ sai lầm:
- Phát hiện lỗi:
Giả sử cả Equals và Times đều có lỗi, TestMultiplication có thể pass sai. Lỗi này có thể không lộ ra ngay cho đến khi một vấn đề khác xuất hiện trong quá trình sử dụng mã.

- Phân tích nguyên nhân: Tại sao lỗi này không bị phát hiện? Có thể chúng ta thiếu một bài kiểm thử riêng để kiểm tra Equals.
Thêm kiểm thử: Viết một bài kiểm thử mới cho Equals để đảm bảo nó hoạt động đúng trong mọi trường hợp.

- Cải thiện: Mỗi lỗi là một bài học. Chúng ta bổ sung kiểm thử để ngăn ngừa các vấn đề tương tự trong tương lai, làm cho hệ thống ngày càng mạnh mẽ hơn.

## Franc-ly Speaking

Chúng ta có thể đang quan tâm đến bước đầu tiên trong danh sách những việc cần làm, nhưng có lẽ vẫn còn quá sớm để xử lý công việc đó.

Một điều kiện tiên quyết có vẻ là cần có một đối tượng giống như Dollar, nhưng để đại diện cho Franc. Nếu chúng ta có thể làm cho Franc hoạt động giống như Dollar hiện tại, thì chúng ta sẽ tiến gần hơn đến việc có thể viết và chạy bài kiểm thử cộng hỗn hợp.

```
To do:
    $5 + 10 CHF = $10 if CHF:USD is 2:1
    ok $5 * 2 = $10
    ok Make “amount” private
    ok Dollar side-effects?
    Money rounding?
    ok Equals()
    HashCode()
    Equal null
    Equal object
    5 CHF * 2 = 10 CHF
```

Chúng ta có thể sao chép và chỉnh sửa bài kiểm thử của Dollar:

```csharp
    [Fact]
    public void TestFrancMultiplication()
    {
        Franc five = new(5);
        Assert.Equal(new Franc(10), five.Times(2));
        Assert.Equal(new Franc(15), five.Times(3));
    }
```

Bước nhỏ nào sẽ giúp chúng ta có một bài kiểm thử chạy đúng? Chỉ cần sao chép mã của Dollar và thay thế "Dollar" bằng "Franc".

Dừng lại. Khoan đã. Tôi có thể nghe thấy những người yêu thích thiết kế đẹp đang chế giễu và phản đối.

Sao chép và dán lại mã? Cái chết của trừu tượng hóa? Kẻ hủy diệt của thiết kế sạch?

Nếu bạn đang khó chịu, hãy hít một hơi thật sâu. Hít vào... giữ... thở ra. Rồi, ổn rồi.

Chu kỳ của chúng ta có các giai đoạn khác nhau (chúng diễn ra nhanh chóng, đôi khi chỉ trong vài giây, nhưng vẫn là các giai đoạn):

1. Viết bài kiểm thử
2. Làm cho nó biên dịch được
3. Làm cho nó chạy được
4. Loại bỏ sự trùng lặp

Các giai đoạn khác nhau có những mục tiêu khác nhau. Chúng yêu cầu các phong cách giải quyết khác nhau, các quan điểm thẩm mỹ khác nhau. Ba bước đầu tiên cần diễn ra nhanh chóng để chúng ta đạt đến trạng thái đã biết với chức năng mới. Bạn có thể phạm bất kỳ sai lầm nào để đạt được điều đó, vì tốc độ quan trọng hơn thiết kế — chỉ trong khoảnh khắc đó thôi.

Bây giờ tôi đang lo lắng. Tôi vừa trao cho bạn một giấy phép để vứt bỏ tất cả các nguyên tắc của thiết kế tốt. Nhưng dừng lại. Chu kỳ chưa hoàn thành. Một con ngựa ba chân không thể phi nước đại. Ba bước đầu tiên của chu kỳ sẽ không hoạt động nếu thiếu bước thứ tư.

Thiết kế tốt vào thời điểm thích hợp.

**Làm cho nó chạy, sau đó làm cho nó đúng.**

Chúng ta đang ở đâu? À, đúng rồi. Vi phạm tất cả các nguyên tắc thiết kế tốt vì tốc độ (chúng ta sẽ chuộc lỗi trong các chương tiếp theo).

```csharp
public class Franc
{
    private int Amount;

    public Franc(int amount)
    {
        Amount = amount;
    }

    public Franc Times(int multiplier)
    {
        return new Franc(Amount * multiplier);
    }

    public override bool Equals(object? obj)
    {
        Franc dollar = (Franc)obj;
        return Amount == dollar.Amount;
    }
}
```

Vì bước để làm cho mã chạy được quá ngắn, chúng ta thậm chí có thể bỏ qua bước “làm cho nó biên dịch”.

Bây giờ, chúng ta có sự trùng lặp khắp nơi, và chúng ta phải loại bỏ nó trước khi viết bài kiểm thử tiếp theo.

Chúng ta sẽ bắt đầu bằng cách tổng quát hóa phương thức Equals(). Tuy nhiên, chúng ta có thể gạch bỏ một mục trong danh sách việc cần làm, mặc dù phải thêm hai mục mới:

```
To do:
    $5 + 10 CHF = $10 if CHF:USD is 2:1
    $5 * 2 = $10
    ok Make “amount” private
    ok Dollar side-effects?
    Money rounding?
    ok Equals()
    HashCode()
    Equal null
    Equal object
    ok 5 CHF * 2 = 10 CHF
    Dollar/Franc duplication
    Common equals
```

Tóm tắt lại:
- Chúng ta không thể giải quyết một bài kiểm thử lớn, nên đã tạo một bài kiểm thử nhỏ hơn để xử lý.
- Viết bài kiểm thử bằng cách sao chép và chỉnh sửa mà không ngần ngại.
- Thậm chí còn tệ hơn, làm cho bài kiểm thử chạy được bằng cách sao chép toàn bộ mã của model.
- Hứa với bản thân rằng sẽ không rời đi cho đến khi loại bỏ hết trùng lặp.

## Equality for All, Redux

Trong chương trước,  chúng ta đã phạm nhiều "tội lỗi" để làm kiểm thử chạy nhanh chóng. Bây giờ là lúc cần dọn dẹp.

Một khả năng là để một trong các lớp kế thừa từ lớp còn lại. Tôi đã thử, nhưng nó hầu như không tiết kiệm được chút mã nguồn nào. Thay vào đó, chúng ta sẽ tìm một lớp cha chung cho cả hai lớp (tôi cũng đã thử cách này, và nó hoạt động rất tốt, mặc dù sẽ mất một chút thời gian).
 
Chúng ta sẽ bắt đầu bằng cách tạo một lớp Money để chứa mã chung của Equals().

```csharp
class Money
```

Tất cả các bài kiểm thử vẫn chạy (không có gì có thể bị phá vỡ vào lúc này, nhưng đây vẫn là thời điểm tốt để chạy kiểm thử).

Nếu Dollar kế thừa từ Money, điều đó không thể gây ra lỗi gì.

```csharp
class Dollar extends Money {
    private int Amount;
}
```

Không có lỗi nào xảy ra. Bây giờ chúng ta có thể di chuyển biến Amount lên Money:

```csharp
class Money {
    protected int Amount;
}
```

Cần thay đổi phạm vi từ private thành protected để lớp con vẫn có thể truy cập được. Bây giờ chúng ta có thể làm cho Equals() sẵn sàng để di chuyển lên. Trước tiên, thay đổi khai báo biến tạm thời:

Cập nhật equals() trong Dollar:

```csharp
    public override bool Equals(object? obj)
    {
        Money dollar = (Dollar)obj;
        return Amount == dollar.Amount;
    }
```

Việc cập nhật Dollar thành Money yêu cầu chúng ta phải đưa Equals lên lớp cha Money để truy cập biến 
Amount:

```csharp
    public override bool Equals(object? obj)
    {
        Money dollar = (Money)obj;
        return Amount == dollar.Amount;
    }
```

Bây giờ chúng ta cần loại bỏ Equals() khỏi Franc. Nhưng trước tiên, hãy kiểm tra lại các bài kiểm thử của chúng ta. Viết thêm một kiểm thử nữa ở lớp DollarTests

```csharp
    [Fact]
    public void TestEquality()
    {
        Assert.True(new Dollar(5).Equals(new Dollar(5)));
        Assert.False(new Dollar(5).Equals(new Dollar(6)));
        Assert.True(new Franc(5).Equals(new Franc(5)));
        Assert.False(new Franc(5).Equals(new Franc(6)));
    }
```

Lại có thêm sự trùng lặp, nhưng chúng ta sẽ xử lý nó sau.

Ok, các kiểm thử cũng đã pass, chúng ta sẽ chỉnh sửa tương tự như lớp Dollar đối với lớp Franc.

Những gì chúng ta đã làm:

- Dần dần di chuyển mã chung từ Dollar lên Money.
- Cho Franc kế thừa từ Money.
- Hợp nhất hai phương thức Equals(), sau đó xóa phương thức dư thừa.

## Apples and Oranges

Chúng ta đã có một suy nghĩ ở cuối chương trước—điều gì sẽ xảy ra khi so sánh Franc và Dollar? Chúng ta đã biến nỗi lo lắng này thành một mục trong danh sách việc cần làm, nhưng vẫn không thể gạt nó khỏi đầu. Vậy điều gì sẽ xảy ra?

```csharp
    [Fact]
    public void TestEquality()
    {
        Assert.True(new Dollar(5).Equals(new Dollar(5)));
        Assert.False(new Dollar(5).Equals(new Dollar(6)));
        Assert.True(new Franc(5).Equals(new Franc(5)));
        Assert.False(new Franc(5).Equals(new Franc(6)));
        Assert.False(new Franc(5).Equals(new Dollar(5)));
    }
```

Kiểm thử thất bại. Dollar và Franc đang được xem là giống nhau. 

Code kiểm tra equals cần phải đảm bảo không so sánh giữa Dollar và Franc. Ta có thể làm điều này bằng cách so sánh loại của hai đối tượng—hai đối tượng Money chỉ bằng nhau nếu số tiền và kiểu class của chúng bằng nhau.

```csharp
 public override bool Equals(object? obj)
    {
        if (obj is not Money money) return false;
        return Amount == money.Amount && GetType() == money.GetType();
    }
```

Hiện tại, việc dùng GetType() để so sánh kiểu có thể xem là một code smell. Trong mô hình domain tài chính, ta nên dùng một tiêu chí hợp lý hơn, chẳng hạn như loại tiền tệ (currency). Nhưng bây giờ, ta chưa có dữ liệu về loại tiền, nên giải pháp này là tạm ổn.

Lúc này, công việc cần làm là:

```
To do:
    $5 + 10 CHF = $10 if CHF:USD is 2:1
    $5 * 2 = $10
    ok Make “amount” private
    ok Dollar side-effects?
    Money rounding?
    ok Equals()
    HashCode()
    Equal null
    Equal object
    ok 5 CHF * 2 = 10 CHF
    Dollar/Franc duplication
    ok Common equals
    Common times
    ok Francs != Dollars
    Currency?
```

Những gì chúng ta đã làm được trong chương này:
- Chuyển một vấn đề tiềm ẩn thành một bài kiểm thử
- Làm cho kiểm thử chạy đúng theo một cách hợp lý, dù chưa hoàn hảo (GetType())
- Chưa vội vàng giới thiệu thiết kế mới cho đến khi có lý do chính đáng.

