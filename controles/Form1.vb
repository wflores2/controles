Public Class Form1
    Public f As String
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        'lblmensaje.Font = New Font(lblmensaje.Font.Size, TrackBar1.Value)
        lblmensaje.Font = New Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Regular)
        Label2.Text = TrackBar1.Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim fuente As String
        Label2.Text = TrackBar1.Value

        For Each fuente In FontFamily.Families
            f = fuente.Name
            ComboBox1.Items.Add(f)
        Next

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            lblmensaje.ForeColor = Color.Red
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            lblmensaje.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            lblmensaje.ForeColor = Color.Green
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        lblmensaje.Font = New Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Regular)
        Label3.Text = ComboBox1.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True And CheckBox2.Checked = False Then
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Regular)
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Bold)
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True Then
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Regular)
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Italic)
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Regular)
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Bold Or FontStyle.Italic)
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Regular)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox1.Checked = False And CheckBox2.Checked = True Then
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Regular)
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Italic)
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Regular)
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Bold)
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Regular)
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Bold Or FontStyle.Italic)
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = False Then
            lblmensaje.Font = New System.Drawing.Font(ComboBox1.Text, TrackBar1.Value, FontStyle.Regular)
        End If
    End Sub

End Class
