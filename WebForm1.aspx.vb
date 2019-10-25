Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        Dim errFlg As Boolean = False

        '入力チェック
        If String.IsNullOrEmpty(Me.txt1.Text) Then
            Me.lblErr1.Text = "入力値１は必須です"
            errFlg = True
        ElseIf Not IsNumeric(Me.txt1.Text) Then
            Me.lblErr1.Text = "入力値１は数値で入力してください"
            errFlg = True
        Else
            Me.lblErr1.Text = String.Empty
        End If

        If String.IsNullOrEmpty(Me.txt2.Text) Then
            Me.lblErr2.Text = "入力値２は必須です"
            errFlg = True
        ElseIf Not IsNumeric(Me.txt2.Text) Then
            Me.lblErr2.Text = "入力値２は数値で入力してください"
            errFlg = True
        Else
            Me.lblErr3.Text = String.Empty
        End If

        If String.IsNullOrEmpty(Me.txt3.Text) Then
            Me.lblErr3.Text = "入力値３は必須です"
            errFlg = True
        ElseIf Not IsNumeric(Me.txt3.Text) Then
            Me.lblErr3.Text = "入力値３は数値で入力してください"
            errFlg = True
        Else
            Me.lblErr3.Text = String.Empty
        End If

        If Not errFlg Then
            Me.lblOk.Text = "OKです"
            Me.lblErr1.Text = ""
            Me.lblErr2.Text = ""
            Me.lblErr3.Text = ""
        Else
            Me.lblOk.Text = ""
        End If

    End Sub
End Class