# C# 學習作業

> 嘗試在不會的語言下學習，並且嘗試使用不熟悉的工具。

## 前置作業

1. 請先閱讀完整份作業需求才開始學習，並且在學習過程中，請隨時閱讀作業需求，以確保學習的內容符合作業需求。
2. 第一次請先把此範本專案上傳至 GitHub ，Repository 命名建議：`CsharpLearning`，並將此 Repository 設為公開，並且將連結寄 Email 給我們。

## 學習計畫

1. 日期：20250718-20250723，每天兩個章節。
2. 每天觀看兩個章節並完成筆記，每個章節為一個 Console App，並且以該章節為專案名稱，如 `Output`、`Variables`、`Constants` 等，並且提交到 GitHub。
3. 可以以註解方式做筆記於 Console App 中，可以參考範例。
4. 一個章節為一個 commit，commit 規則請參考 **Git 版本控制要求** 。

## 求助方式

在學習過程中如果遇到任何問題，歡迎透過 Email 聯繫我們：

**技術問題與學習困難：**
- 林書正：ShawnLin@uitc.com.tw
- 莊理竣：LijungJhuang@uitc.com.tw

**Email 主旨格式：**`[C# 學習作業] 問題描述`

**建議在 Email 中包含：**
- 具體遇到的問題或錯誤訊息
- 已經嘗試過的解決方法
- 相關的程式碼片段（如果有的話）
- 目前的學習進度

## 資料夾結構

```
CsharpLearn.sln
├── README.md
├── Output
│   ├── Output.csproj
│   ├── Program.cs
├── Variables
│   ├── Variables.csproj
│   ├── Program.cs
├── Constants
│   ├── Constants.csproj
│   ├── Program.cs
├── ...
```

## 課程資源

**主要教學影片：** [C# Full Course for free 🚀 - YouTube](https://www.youtube.com/watch?v=wxznTygnRfQ)

📌 重要提醒： 影片開頭包含開發環境安裝教學，請務必先觀看並完成環境設定，再開始後續的學習章節

**課程大綱：**

- 2 (00:06:30) output 💬
- 3 (00:10:48) variables ✖️
- 4 (00:19:32) constants π
- 5 (00:20:35) type casting 💱
- 6 (00:27:49) user input ⌨️
- 7 (00:31:24) arithmetic operators 🧮
- 8 (00:35:54) Math class 📏
- 9 (00:40:55) random numbers 🎲
- 10 (00:44:27) hypotenuse calculator program 📐
- 11 (00:46:35) string methods 🔤
- 12 (00:53:26) if statements 🤔
- 13 (00:59:43) switches 🔀

## Git 版本控制要求

- 每完成一個主題章節，必須進行一次 commit
- commit 訊息格式：`完成：章節名稱`

## 範例

Output/Program.cs

```csharp

// 輸出 Hello World 用於測試是否能夠正常運行
// Question: 為什麼要輸出 Hello World 呢？
Console.WriteLine("Hello World");
```
