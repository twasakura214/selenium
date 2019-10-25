Imports System.Text
Imports System.Threading
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.IE

<TestClass()> Public Class UnitTest1

    Dim browser As IWebDriver = New ChromeDriver
    'Dim browser As IWebDriver = New InternetExplorerDriver

    <TestMethod()> Public Sub TestMethod1()

        browser.Url = "http://localhost/SelemiumTestWebApplication/WebForm1"

        '--------------------------
        '必須入力チェック
        '--------------------------
        browser.FindElement(By.Id("btn1")).Click()

        Dim err1 As String = browser.FindElement(By.Id("lblErr1")).Text
        Dim err2 As String = browser.FindElement(By.Id("lblErr2")).Text
        Dim err3 As String = browser.FindElement(By.Id("lblErr3")).Text

        Assert.AreEqual("入力値１は必須です", err1, "error1")
        Assert.AreEqual("入力値２は必須です", err2, "error2")
        Assert.AreEqual("入力値３は必須です", err3, "error3")

        '---------------------------
        '数値チェック
        '---------------------------
        browser.FindElement(By.Id("txt1")).SendKeys("aa")
        browser.FindElement(By.Id("btn1")).Click()

        err1 = browser.FindElement(By.Id("lblErr1")).Text
        Assert.AreEqual("入力値１は数値で入力してください", err1, "error1")



    End Sub

    <TestCleanup> Public Sub lastTest()
        Thread.Sleep(3000)
        browser.Quit()
    End Sub
End Class