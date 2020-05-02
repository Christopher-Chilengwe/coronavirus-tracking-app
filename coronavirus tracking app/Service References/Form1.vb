Imports HtmlAgilityPack


Public Class Form1

  

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.kashipara.com/profile/user/hemakumar72")

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.worldometers.info/coronavirus/?")


    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Application.Exit()

    End Sub

  

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
     
        Control.CheckForIllegalCrossThreadCalls = False
        BackgroundWorker1.RunWorkerAsync()

    End Sub


    

   

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Try
            imbut.Visible = False

            bucircle.Value = "5"
            Dim webget As New HtmlWeb

            Dim doc As HtmlDocument = webget.Load("https://api.thevirustracker.com/free-api")

            bucircle.Value = "30"
            Dim works As HtmlNodeCollection = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[4]/div[1]/h1")


            Label2.Text = works(0).InnerText


            bucircle.Value = "50"
            Dim works2 As HtmlNodeCollection = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[4]/div[2]/h1")

            Label4.Text = works2(0).InnerText

            bucircle.Value = "80"


            Panel2.Visible = False



            Dim works3 As HtmlNodeCollection = doc.DocumentNode.SelectNodes("/html/body/div[3]/div[4]/div[3]/h1")
            Label6.Text = works3(0).InnerText

            bucircle.Value = "99"
            bucircle.Value = "0"
            imbut.Visible = True


        Catch ex As Exception
            MessageBox.Show("please check internet connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Panel2.Visible = False

            bucircle.Value = "0"

        End Try



    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles imbut.Click


        BackgroundWorker1.RunWorkerAsync()


    End Sub
End Class

