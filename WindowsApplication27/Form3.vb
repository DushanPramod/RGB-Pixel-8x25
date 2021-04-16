Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

        If (Form1.CheckBox1.CheckState = CheckState.Checked) Then
            F.Text = "void " & Form1.TextBox1.Text & "() {"
            F.Text = F.Text & vbNewLine & "  cleara8x25();"

            If (Form1.b1(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][0][0] = " & Form1.b1(0) & ";"
            End If
            If (Form1.b1(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][0][1] = " & Form1.b1(1) & ";"
            End If
            If (Form1.b1(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][0][2] = " & Form1.b1(2) & ";"
            End If
            If (Form1.b2(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][0][0] = " & Form1.b2(0) & ";"
            End If
            If (Form1.b2(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][0][1] = " & Form1.b2(1) & ";"
            End If
            If (Form1.b2(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][0][2] = " & Form1.b2(2) & ";"
            End If
            If (Form1.b3(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][0][0] = " & Form1.b3(0) & ";"
            End If
            If (Form1.b3(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][0][1] = " & Form1.b3(1) & ";"
            End If
            If (Form1.b3(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][0][2] = " & Form1.b3(2) & ";"
            End If
            If (Form1.b4(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][0][0] = " & Form1.b4(0) & ";"
            End If
            If (Form1.b4(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][0][1] = " & Form1.b4(1) & ";"
            End If
            If (Form1.b4(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][0][2] = " & Form1.b4(2) & ";"
            End If
            If (Form1.b5(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][0][0] = " & Form1.b5(0) & ";"
            End If
            If (Form1.b5(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][0][1] = " & Form1.b5(1) & ";"
            End If
            If (Form1.b5(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][0][2] = " & Form1.b5(2) & ";"
            End If
            If (Form1.b6(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][0][0] = " & Form1.b6(0) & ";"
            End If
            If (Form1.b6(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][0][1] = " & Form1.b6(1) & ";"
            End If
            If (Form1.b6(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][0][2] = " & Form1.b6(2) & ";"
            End If
            If (Form1.b7(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][0][0] = " & Form1.b7(0) & ";"
            End If
            If (Form1.b7(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][0][1] = " & Form1.b7(1) & ";"
            End If
            If (Form1.b7(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][0][2] = " & Form1.b7(2) & ";"
            End If
            If (Form1.b8(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][0][0] = " & Form1.b8(0) & ";"
            End If
            If (Form1.b8(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][0][1] = " & Form1.b8(1) & ";"
            End If
            If (Form1.b8(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][0][2] = " & Form1.b8(2) & ";"
            End If
            If (Form1.b17(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][2][0] = " & Form1.b17(0) & ";"
            End If
            If (Form1.b17(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][2][1] = " & Form1.b17(1) & ";"
            End If
            If (Form1.b17(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][2][2] = " & Form1.b17(2) & ";"
            End If
            If (Form1.b18(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][2][0] = " & Form1.b18(0) & ";"
            End If
            If (Form1.b18(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][2][1] = " & Form1.b18(1) & ";"
            End If
            If (Form1.b18(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][2][2] = " & Form1.b18(2) & ";"
            End If
            If (Form1.b19(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][2][0] = " & Form1.b19(0) & ";"
            End If
            If (Form1.b19(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][2][1] = " & Form1.b19(1) & ";"
            End If
            If (Form1.b19(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][2][2] = " & Form1.b19(2) & ";"
            End If
            If (Form1.b20(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][2][0] = " & Form1.b20(0) & ";"
            End If
            If (Form1.b20(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][2][1] = " & Form1.b20(1) & ";"
            End If
            If (Form1.b20(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][2][2] = " & Form1.b20(2) & ";"
            End If
            If (Form1.b21(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][2][0] = " & Form1.b21(0) & ";"
            End If
            If (Form1.b21(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][2][1] = " & Form1.b21(1) & ";"
            End If
            If (Form1.b21(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][2][2] = " & Form1.b21(2) & ";"
            End If
            If (Form1.b22(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][2][0] = " & Form1.b22(0) & ";"
            End If
            If (Form1.b22(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][2][1] = " & Form1.b22(1) & ";"
            End If
            If (Form1.b22(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][2][2] = " & Form1.b22(2) & ";"
            End If
            If (Form1.b23(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][2][0] = " & Form1.b23(0) & ";"
            End If
            If (Form1.b23(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][2][1] = " & Form1.b23(1) & ";"
            End If
            If (Form1.b23(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][2][2] = " & Form1.b23(2) & ";"
            End If
            If (Form1.b24(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][2][0] = " & Form1.b24(0) & ";"
            End If
            If (Form1.b24(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][2][1] = " & Form1.b24(1) & ";"
            End If
            If (Form1.b24(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][2][2] = " & Form1.b24(2) & ";"
            End If
            If (Form1.b33(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][4][0] = " & Form1.b33(0) & ";"
            End If
            If (Form1.b33(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][4][1] = " & Form1.b33(1) & ";"
            End If
            If (Form1.b33(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][4][2] = " & Form1.b33(2) & ";"
            End If
            If (Form1.b34(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][4][0] = " & Form1.b34(0) & ";"
            End If
            If (Form1.b34(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][4][1] = " & Form1.b34(1) & ";"
            End If
            If (Form1.b34(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][4][2] = " & Form1.b34(2) & ";"
            End If
            If (Form1.b35(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][4][0] = " & Form1.b35(0) & ";"
            End If
            If (Form1.b35(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][4][1] = " & Form1.b35(1) & ";"
            End If
            If (Form1.b35(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][4][2] = " & Form1.b35(2) & ";"
            End If
            If (Form1.b36(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][4][0] = " & Form1.b36(0) & ";"
            End If
            If (Form1.b36(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][4][1] = " & Form1.b36(1) & ";"
            End If
            If (Form1.b36(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][4][2] = " & Form1.b36(2) & ";"
            End If
            If (Form1.b37(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][4][0] = " & Form1.b37(0) & ";"
            End If
            If (Form1.b37(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][4][1] = " & Form1.b37(1) & ";"
            End If
            If (Form1.b37(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][4][2] = " & Form1.b37(2) & ";"
            End If
            If (Form1.b38(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][4][0] = " & Form1.b38(0) & ";"
            End If
            If (Form1.b38(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][4][1] = " & Form1.b38(1) & ";"
            End If
            If (Form1.b38(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][4][2] = " & Form1.b38(2) & ";"
            End If
            If (Form1.b39(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][4][0] = " & Form1.b39(0) & ";"
            End If
            If (Form1.b39(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][4][1] = " & Form1.b39(1) & ";"
            End If
            If (Form1.b39(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][4][2] = " & Form1.b39(2) & ";"
            End If
            If (Form1.b40(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][4][0] = " & Form1.b40(0) & ";"
            End If
            If (Form1.b40(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][4][1] = " & Form1.b40(1) & ";"
            End If
            If (Form1.b40(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][4][2] = " & Form1.b40(2) & ";"
            End If
            If (Form1.b49(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][6][0] = " & Form1.b49(0) & ";"
            End If
            If (Form1.b49(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][6][1] = " & Form1.b49(1) & ";"
            End If
            If (Form1.b49(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][6][2] = " & Form1.b49(2) & ";"
            End If
            If (Form1.b50(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][6][0] = " & Form1.b50(0) & ";"
            End If
            If (Form1.b50(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][6][1] = " & Form1.b50(1) & ";"
            End If
            If (Form1.b50(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][6][2] = " & Form1.b50(2) & ";"
            End If
            If (Form1.b51(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][6][0] = " & Form1.b51(0) & ";"
            End If
            If (Form1.b51(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][6][1] = " & Form1.b51(1) & ";"
            End If
            If (Form1.b51(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][6][2] = " & Form1.b51(2) & ";"
            End If
            If (Form1.b52(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][6][0] = " & Form1.b52(0) & ";"
            End If
            If (Form1.b52(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][6][1] = " & Form1.b52(1) & ";"
            End If
            If (Form1.b52(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][6][2] = " & Form1.b52(2) & ";"
            End If
            If (Form1.b53(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][6][0] = " & Form1.b53(0) & ";"
            End If
            If (Form1.b53(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][6][1] = " & Form1.b53(1) & ";"
            End If
            If (Form1.b53(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][6][2] = " & Form1.b53(2) & ";"
            End If
            If (Form1.b54(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][6][0] = " & Form1.b54(0) & ";"
            End If
            If (Form1.b54(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][6][1] = " & Form1.b54(1) & ";"
            End If
            If (Form1.b54(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][6][2] = " & Form1.b54(2) & ";"
            End If
            If (Form1.b55(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][6][0] = " & Form1.b55(0) & ";"
            End If
            If (Form1.b55(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][6][1] = " & Form1.b55(1) & ";"
            End If
            If (Form1.b55(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][6][2] = " & Form1.b55(2) & ";"
            End If
            If (Form1.b56(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][6][0] = " & Form1.b56(0) & ";"
            End If
            If (Form1.b56(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][6][1] = " & Form1.b56(1) & ";"
            End If
            If (Form1.b56(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][6][2] = " & Form1.b56(2) & ";"
            End If
            If (Form1.b65(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][8][0] = " & Form1.b65(0) & ";"
            End If
            If (Form1.b65(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][8][1] = " & Form1.b65(1) & ";"
            End If
            If (Form1.b65(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][8][2] = " & Form1.b65(2) & ";"
            End If
            If (Form1.b66(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][8][0] = " & Form1.b66(0) & ";"
            End If
            If (Form1.b66(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][8][1] = " & Form1.b66(1) & ";"
            End If
            If (Form1.b66(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][8][2] = " & Form1.b66(2) & ";"
            End If
            If (Form1.b67(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][8][0] = " & Form1.b67(0) & ";"
            End If
            If (Form1.b67(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][8][1] = " & Form1.b67(1) & ";"
            End If
            If (Form1.b67(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][8][2] = " & Form1.b67(2) & ";"
            End If
            If (Form1.b68(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][8][0] = " & Form1.b68(0) & ";"
            End If
            If (Form1.b68(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][8][1] = " & Form1.b68(1) & ";"
            End If
            If (Form1.b68(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][8][2] = " & Form1.b68(2) & ";"
            End If
            If (Form1.b69(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][8][0] = " & Form1.b69(0) & ";"
            End If
            If (Form1.b69(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][8][1] = " & Form1.b69(1) & ";"
            End If
            If (Form1.b69(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][8][2] = " & Form1.b69(2) & ";"
            End If
            If (Form1.b70(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][8][0] = " & Form1.b70(0) & ";"
            End If
            If (Form1.b70(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][8][1] = " & Form1.b70(1) & ";"
            End If
            If (Form1.b70(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][8][2] = " & Form1.b70(2) & ";"
            End If
            If (Form1.b71(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][8][0] = " & Form1.b71(0) & ";"
            End If
            If (Form1.b71(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][8][1] = " & Form1.b71(1) & ";"
            End If
            If (Form1.b71(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][8][2] = " & Form1.b71(2) & ";"
            End If
            If (Form1.b72(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][8][0] = " & Form1.b72(0) & ";"
            End If
            If (Form1.b72(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][8][1] = " & Form1.b72(1) & ";"
            End If
            If (Form1.b72(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][8][2] = " & Form1.b72(2) & ";"
            End If
            If (Form1.b81(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][10][0] = " & Form1.b81(0) & ";"
            End If
            If (Form1.b81(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][10][1] = " & Form1.b81(1) & ";"
            End If
            If (Form1.b81(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][10][2] = " & Form1.b81(2) & ";"
            End If
            If (Form1.b82(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][10][0] = " & Form1.b82(0) & ";"
            End If
            If (Form1.b82(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][10][1] = " & Form1.b82(1) & ";"
            End If
            If (Form1.b82(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][10][2] = " & Form1.b82(2) & ";"
            End If
            If (Form1.b83(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][10][0] = " & Form1.b83(0) & ";"
            End If
            If (Form1.b83(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][10][1] = " & Form1.b83(1) & ";"
            End If
            If (Form1.b83(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][10][2] = " & Form1.b83(2) & ";"
            End If
            If (Form1.b84(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][10][0] = " & Form1.b84(0) & ";"
            End If
            If (Form1.b84(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][10][1] = " & Form1.b84(1) & ";"
            End If
            If (Form1.b84(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][10][2] = " & Form1.b84(2) & ";"
            End If
            If (Form1.b85(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][10][0] = " & Form1.b85(0) & ";"
            End If
            If (Form1.b85(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][10][1] = " & Form1.b85(1) & ";"
            End If
            If (Form1.b85(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][10][2] = " & Form1.b85(2) & ";"
            End If
            If (Form1.b86(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][10][0] = " & Form1.b86(0) & ";"
            End If
            If (Form1.b86(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][10][1] = " & Form1.b86(1) & ";"
            End If
            If (Form1.b86(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][10][2] = " & Form1.b86(2) & ";"
            End If
            If (Form1.b87(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][10][0] = " & Form1.b87(0) & ";"
            End If
            If (Form1.b87(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][10][1] = " & Form1.b87(1) & ";"
            End If
            If (Form1.b87(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][10][2] = " & Form1.b87(2) & ";"
            End If
            If (Form1.b88(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][10][0] = " & Form1.b88(0) & ";"
            End If
            If (Form1.b88(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][10][1] = " & Form1.b88(1) & ";"
            End If
            If (Form1.b88(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][10][2] = " & Form1.b88(2) & ";"
            End If
            If (Form1.b97(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][12][0] = " & Form1.b97(0) & ";"
            End If
            If (Form1.b97(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][12][1] = " & Form1.b97(1) & ";"
            End If
            If (Form1.b97(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][12][2] = " & Form1.b97(2) & ";"
            End If
            If (Form1.b98(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][12][0] = " & Form1.b98(0) & ";"
            End If
            If (Form1.b98(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][12][1] = " & Form1.b98(1) & ";"
            End If
            If (Form1.b98(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][12][2] = " & Form1.b98(2) & ";"
            End If
            If (Form1.b99(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][12][0] = " & Form1.b99(0) & ";"
            End If
            If (Form1.b99(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][12][1] = " & Form1.b99(1) & ";"
            End If
            If (Form1.b99(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][12][2] = " & Form1.b99(2) & ";"
            End If
            If (Form1.b100(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][12][0] = " & Form1.b100(0) & ";"
            End If
            If (Form1.b100(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][12][1] = " & Form1.b100(1) & ";"
            End If
            If (Form1.b100(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][12][2] = " & Form1.b100(2) & ";"
            End If
            If (Form1.b101(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][12][0] = " & Form1.b101(0) & ";"
            End If
            If (Form1.b101(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][12][1] = " & Form1.b101(1) & ";"
            End If
            If (Form1.b101(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][12][2] = " & Form1.b101(2) & ";"
            End If
            If (Form1.b102(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][12][0] = " & Form1.b102(0) & ";"
            End If
            If (Form1.b102(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][12][1] = " & Form1.b102(1) & ";"
            End If
            If (Form1.b102(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][12][2] = " & Form1.b102(2) & ";"
            End If
            If (Form1.b103(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][12][0] = " & Form1.b103(0) & ";"
            End If
            If (Form1.b103(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][12][1] = " & Form1.b103(1) & ";"
            End If
            If (Form1.b103(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][12][2] = " & Form1.b103(2) & ";"
            End If
            If (Form1.b104(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][12][0] = " & Form1.b104(0) & ";"
            End If
            If (Form1.b104(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][12][1] = " & Form1.b104(1) & ";"
            End If
            If (Form1.b104(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][12][2] = " & Form1.b104(2) & ";"
            End If
            If (Form1.b113(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][14][0] = " & Form1.b113(0) & ";"
            End If
            If (Form1.b113(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][14][1] = " & Form1.b113(1) & ";"
            End If
            If (Form1.b113(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][14][2] = " & Form1.b113(2) & ";"
            End If
            If (Form1.b114(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][14][0] = " & Form1.b114(0) & ";"
            End If
            If (Form1.b114(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][14][1] = " & Form1.b114(1) & ";"
            End If
            If (Form1.b114(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][14][2] = " & Form1.b114(2) & ";"
            End If
            If (Form1.b115(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][14][0] = " & Form1.b115(0) & ";"
            End If
            If (Form1.b115(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][14][1] = " & Form1.b115(1) & ";"
            End If
            If (Form1.b115(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][14][2] = " & Form1.b115(2) & ";"
            End If
            If (Form1.b116(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][14][0] = " & Form1.b116(0) & ";"
            End If
            If (Form1.b116(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][14][1] = " & Form1.b116(1) & ";"
            End If
            If (Form1.b116(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][14][2] = " & Form1.b116(2) & ";"
            End If
            If (Form1.b117(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][14][0] = " & Form1.b117(0) & ";"
            End If
            If (Form1.b117(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][14][1] = " & Form1.b117(1) & ";"
            End If
            If (Form1.b117(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][14][2] = " & Form1.b117(2) & ";"
            End If
            If (Form1.b118(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][14][0] = " & Form1.b118(0) & ";"
            End If
            If (Form1.b118(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][14][1] = " & Form1.b118(1) & ";"
            End If
            If (Form1.b118(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][14][2] = " & Form1.b118(2) & ";"
            End If
            If (Form1.b119(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][14][0] = " & Form1.b119(0) & ";"
            End If
            If (Form1.b119(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][14][1] = " & Form1.b119(1) & ";"
            End If
            If (Form1.b119(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][14][2] = " & Form1.b119(2) & ";"
            End If
            If (Form1.b120(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][14][0] = " & Form1.b120(0) & ";"
            End If
            If (Form1.b120(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][14][1] = " & Form1.b120(1) & ";"
            End If
            If (Form1.b120(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][14][2] = " & Form1.b120(2) & ";"
            End If
            If (Form1.b129(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][16][0] = " & Form1.b129(0) & ";"
            End If
            If (Form1.b129(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][16][1] = " & Form1.b129(1) & ";"
            End If
            If (Form1.b129(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][16][2] = " & Form1.b129(2) & ";"
            End If
            If (Form1.b130(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][16][0] = " & Form1.b130(0) & ";"
            End If
            If (Form1.b130(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][16][1] = " & Form1.b130(1) & ";"
            End If
            If (Form1.b130(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][16][2] = " & Form1.b130(2) & ";"
            End If
            If (Form1.b131(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][16][0] = " & Form1.b131(0) & ";"
            End If
            If (Form1.b131(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][16][1] = " & Form1.b131(1) & ";"
            End If
            If (Form1.b131(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][16][2] = " & Form1.b131(2) & ";"
            End If
            If (Form1.b132(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][16][0] = " & Form1.b132(0) & ";"
            End If
            If (Form1.b132(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][16][1] = " & Form1.b132(1) & ";"
            End If
            If (Form1.b132(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][16][2] = " & Form1.b132(2) & ";"
            End If
            If (Form1.b133(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][16][0] = " & Form1.b133(0) & ";"
            End If
            If (Form1.b133(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][16][1] = " & Form1.b133(1) & ";"
            End If
            If (Form1.b133(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][16][2] = " & Form1.b133(2) & ";"
            End If
            If (Form1.b134(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][16][0] = " & Form1.b134(0) & ";"
            End If
            If (Form1.b134(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][16][1] = " & Form1.b134(1) & ";"
            End If
            If (Form1.b134(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][16][2] = " & Form1.b134(2) & ";"
            End If
            If (Form1.b135(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][16][0] = " & Form1.b135(0) & ";"
            End If
            If (Form1.b135(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][16][1] = " & Form1.b135(1) & ";"
            End If
            If (Form1.b135(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][16][2] = " & Form1.b135(2) & ";"
            End If
            If (Form1.b136(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][16][0] = " & Form1.b136(0) & ";"
            End If
            If (Form1.b136(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][16][1] = " & Form1.b136(1) & ";"
            End If
            If (Form1.b136(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][16][2] = " & Form1.b136(2) & ";"
            End If
            If (Form1.b145(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][18][0] = " & Form1.b145(0) & ";"
            End If
            If (Form1.b145(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][18][1] = " & Form1.b145(1) & ";"
            End If
            If (Form1.b145(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][18][2] = " & Form1.b145(2) & ";"
            End If
            If (Form1.b146(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][18][0] = " & Form1.b146(0) & ";"
            End If
            If (Form1.b146(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][18][1] = " & Form1.b146(1) & ";"
            End If
            If (Form1.b146(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][18][2] = " & Form1.b146(2) & ";"
            End If
            If (Form1.b147(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][18][0] = " & Form1.b147(0) & ";"
            End If
            If (Form1.b147(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][18][1] = " & Form1.b147(1) & ";"
            End If
            If (Form1.b147(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][18][2] = " & Form1.b147(2) & ";"
            End If
            If (Form1.b148(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][18][0] = " & Form1.b148(0) & ";"
            End If
            If (Form1.b148(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][18][1] = " & Form1.b148(1) & ";"
            End If
            If (Form1.b148(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][18][2] = " & Form1.b148(2) & ";"
            End If
            If (Form1.b149(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][18][0] = " & Form1.b149(0) & ";"
            End If
            If (Form1.b149(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][18][1] = " & Form1.b149(1) & ";"
            End If
            If (Form1.b149(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][18][2] = " & Form1.b149(2) & ";"
            End If
            If (Form1.b150(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][18][0] = " & Form1.b150(0) & ";"
            End If
            If (Form1.b150(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][18][1] = " & Form1.b150(1) & ";"
            End If
            If (Form1.b150(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][18][2] = " & Form1.b150(2) & ";"
            End If
            If (Form1.b151(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][18][0] = " & Form1.b151(0) & ";"
            End If
            If (Form1.b151(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][18][1] = " & Form1.b151(1) & ";"
            End If
            If (Form1.b151(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][18][2] = " & Form1.b151(2) & ";"
            End If
            If (Form1.b152(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][18][0] = " & Form1.b152(0) & ";"
            End If
            If (Form1.b152(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][18][1] = " & Form1.b152(1) & ";"
            End If
            If (Form1.b152(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][18][2] = " & Form1.b152(2) & ";"
            End If
            If (Form1.b161(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][20][0] = " & Form1.b161(0) & ";"
            End If
            If (Form1.b161(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][20][1] = " & Form1.b161(1) & ";"
            End If
            If (Form1.b161(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][20][2] = " & Form1.b161(2) & ";"
            End If
            If (Form1.b162(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][20][0] = " & Form1.b162(0) & ";"
            End If
            If (Form1.b162(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][20][1] = " & Form1.b162(1) & ";"
            End If
            If (Form1.b162(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][20][2] = " & Form1.b162(2) & ";"
            End If
            If (Form1.b163(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][20][0] = " & Form1.b163(0) & ";"
            End If
            If (Form1.b163(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][20][1] = " & Form1.b163(1) & ";"
            End If
            If (Form1.b163(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][20][2] = " & Form1.b163(2) & ";"
            End If
            If (Form1.b164(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][20][0] = " & Form1.b164(0) & ";"
            End If
            If (Form1.b164(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][20][1] = " & Form1.b164(1) & ";"
            End If
            If (Form1.b164(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][20][2] = " & Form1.b164(2) & ";"
            End If
            If (Form1.b165(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][20][0] = " & Form1.b165(0) & ";"
            End If
            If (Form1.b165(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][20][1] = " & Form1.b165(1) & ";"
            End If
            If (Form1.b165(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][20][2] = " & Form1.b165(2) & ";"
            End If
            If (Form1.b166(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][20][0] = " & Form1.b166(0) & ";"
            End If
            If (Form1.b166(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][20][1] = " & Form1.b166(1) & ";"
            End If
            If (Form1.b166(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][20][2] = " & Form1.b166(2) & ";"
            End If
            If (Form1.b167(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][20][0] = " & Form1.b167(0) & ";"
            End If
            If (Form1.b167(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][20][1] = " & Form1.b167(1) & ";"
            End If
            If (Form1.b167(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][20][2] = " & Form1.b167(2) & ";"
            End If
            If (Form1.b168(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][20][0] = " & Form1.b168(0) & ";"
            End If
            If (Form1.b168(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][20][1] = " & Form1.b168(1) & ";"
            End If
            If (Form1.b168(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][20][2] = " & Form1.b168(2) & ";"
            End If
            If (Form1.b177(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][22][0] = " & Form1.b177(0) & ";"
            End If
            If (Form1.b177(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][22][1] = " & Form1.b177(1) & ";"
            End If
            If (Form1.b177(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][22][2] = " & Form1.b177(2) & ";"
            End If
            If (Form1.b178(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][22][0] = " & Form1.b178(0) & ";"
            End If
            If (Form1.b178(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][22][1] = " & Form1.b178(1) & ";"
            End If
            If (Form1.b178(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][22][2] = " & Form1.b178(2) & ";"
            End If
            If (Form1.b179(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][22][0] = " & Form1.b179(0) & ";"
            End If
            If (Form1.b179(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][22][1] = " & Form1.b179(1) & ";"
            End If
            If (Form1.b179(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][22][2] = " & Form1.b179(2) & ";"
            End If
            If (Form1.b180(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][22][0] = " & Form1.b180(0) & ";"
            End If
            If (Form1.b180(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][22][1] = " & Form1.b180(1) & ";"
            End If
            If (Form1.b180(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][22][2] = " & Form1.b180(2) & ";"
            End If
            If (Form1.b181(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][22][0] = " & Form1.b181(0) & ";"
            End If
            If (Form1.b181(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][22][1] = " & Form1.b181(1) & ";"
            End If
            If (Form1.b181(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][22][2] = " & Form1.b181(2) & ";"
            End If
            If (Form1.b182(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][22][0] = " & Form1.b182(0) & ";"
            End If
            If (Form1.b182(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][22][1] = " & Form1.b182(1) & ";"
            End If
            If (Form1.b182(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][22][2] = " & Form1.b182(2) & ";"
            End If
            If (Form1.b183(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][22][0] = " & Form1.b183(0) & ";"
            End If
            If (Form1.b183(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][22][1] = " & Form1.b183(1) & ";"
            End If
            If (Form1.b183(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][22][2] = " & Form1.b183(2) & ";"
            End If
            If (Form1.b184(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][22][0] = " & Form1.b184(0) & ";"
            End If
            If (Form1.b184(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][22][1] = " & Form1.b184(1) & ";"
            End If
            If (Form1.b184(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][22][2] = " & Form1.b184(2) & ";"
            End If
            If (Form1.b193(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][24][0] = " & Form1.b193(0) & ";"
            End If
            If (Form1.b193(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][24][1] = " & Form1.b193(1) & ";"
            End If
            If (Form1.b193(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][24][2] = " & Form1.b193(2) & ";"
            End If
            If (Form1.b194(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][24][0] = " & Form1.b194(0) & ";"
            End If
            If (Form1.b194(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][24][1] = " & Form1.b194(1) & ";"
            End If
            If (Form1.b194(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][24][2] = " & Form1.b194(2) & ";"
            End If
            If (Form1.b195(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][24][0] = " & Form1.b195(0) & ";"
            End If
            If (Form1.b195(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][24][1] = " & Form1.b195(1) & ";"
            End If
            If (Form1.b195(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][24][2] = " & Form1.b195(2) & ";"
            End If
            If (Form1.b196(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][24][0] = " & Form1.b196(0) & ";"
            End If
            If (Form1.b196(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][24][1] = " & Form1.b196(1) & ";"
            End If
            If (Form1.b196(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][24][2] = " & Form1.b196(2) & ";"
            End If
            If (Form1.b197(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][24][0] = " & Form1.b197(0) & ";"
            End If
            If (Form1.b197(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][24][1] = " & Form1.b197(1) & ";"
            End If
            If (Form1.b197(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][24][2] = " & Form1.b197(2) & ";"
            End If
            If (Form1.b198(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][24][0] = " & Form1.b198(0) & ";"
            End If
            If (Form1.b198(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][24][1] = " & Form1.b198(1) & ";"
            End If
            If (Form1.b198(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][24][2] = " & Form1.b198(2) & ";"
            End If
            If (Form1.b199(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][24][0] = " & Form1.b199(0) & ";"
            End If
            If (Form1.b199(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][24][1] = " & Form1.b199(1) & ";"
            End If
            If (Form1.b199(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][24][2] = " & Form1.b199(2) & ";"
            End If
            If (Form1.b200(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][24][0] = " & Form1.b200(0) & ";"
            End If
            If (Form1.b200(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][24][1] = " & Form1.b200(1) & ";"
            End If
            If (Form1.b200(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][24][2] = " & Form1.b200(2) & ";"
            End If




            If (Form1.b16(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][1][0] = " & Form1.b16(0) & ";"
            End If
            If (Form1.b16(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][1][1] = " & Form1.b16(1) & ";"
            End If
            If (Form1.b16(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][1][2] = " & Form1.b16(2) & ";"
            End If
            If (Form1.b15(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][1][0] = " & Form1.b15(0) & ";"
            End If
            If (Form1.b15(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][1][1] = " & Form1.b15(1) & ";"
            End If
            If (Form1.b15(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][1][2] = " & Form1.b15(2) & ";"
            End If
            If (Form1.b14(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][1][0] = " & Form1.b14(0) & ";"
            End If
            If (Form1.b14(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][1][1] = " & Form1.b14(1) & ";"
            End If
            If (Form1.b14(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][1][2] = " & Form1.b14(2) & ";"
            End If
            If (Form1.b13(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][1][0] = " & Form1.b13(0) & ";"
            End If
            If (Form1.b13(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][1][1] = " & Form1.b13(1) & ";"
            End If
            If (Form1.b13(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][1][2] = " & Form1.b13(2) & ";"
            End If
            If (Form1.b12(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][1][0] = " & Form1.b12(0) & ";"
            End If
            If (Form1.b12(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][1][1] = " & Form1.b12(1) & ";"
            End If
            If (Form1.b12(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][1][2] = " & Form1.b12(2) & ";"
            End If
            If (Form1.b11(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][1][0] = " & Form1.b11(0) & ";"
            End If
            If (Form1.b11(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][1][1] = " & Form1.b11(1) & ";"
            End If
            If (Form1.b11(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][1][2] = " & Form1.b11(2) & ";"
            End If
            If (Form1.b10(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][1][0] = " & Form1.b10(0) & ";"
            End If
            If (Form1.b10(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][1][1] = " & Form1.b10(1) & ";"
            End If
            If (Form1.b10(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][1][2] = " & Form1.b10(2) & ";"
            End If
            If (Form1.b9(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][1][0] = " & Form1.b9(0) & ";"
            End If
            If (Form1.b9(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][1][1] = " & Form1.b9(1) & ";"
            End If
            If (Form1.b9(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][1][2] = " & Form1.b9(2) & ";"
            End If
            If (Form1.b32(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][3][0] = " & Form1.b32(0) & ";"
            End If
            If (Form1.b32(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][3][1] = " & Form1.b32(1) & ";"
            End If
            If (Form1.b32(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][3][2] = " & Form1.b32(2) & ";"
            End If
            If (Form1.b31(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][3][0] = " & Form1.b31(0) & ";"
            End If
            If (Form1.b31(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][3][1] = " & Form1.b31(1) & ";"
            End If
            If (Form1.b31(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][3][2] = " & Form1.b31(2) & ";"
            End If
            If (Form1.b30(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][3][0] = " & Form1.b30(0) & ";"
            End If
            If (Form1.b30(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][3][1] = " & Form1.b30(1) & ";"
            End If
            If (Form1.b30(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][3][2] = " & Form1.b30(2) & ";"
            End If
            If (Form1.b29(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][3][0] = " & Form1.b29(0) & ";"
            End If
            If (Form1.b29(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][3][1] = " & Form1.b29(1) & ";"
            End If
            If (Form1.b29(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][3][2] = " & Form1.b29(2) & ";"
            End If
            If (Form1.b28(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][3][0] = " & Form1.b28(0) & ";"
            End If
            If (Form1.b28(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][3][1] = " & Form1.b28(1) & ";"
            End If
            If (Form1.b28(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][3][2] = " & Form1.b28(2) & ";"
            End If
            If (Form1.b27(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][3][0] = " & Form1.b27(0) & ";"
            End If
            If (Form1.b27(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][3][1] = " & Form1.b27(1) & ";"
            End If
            If (Form1.b27(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][3][2] = " & Form1.b27(2) & ";"
            End If
            If (Form1.b26(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][3][0] = " & Form1.b26(0) & ";"
            End If
            If (Form1.b26(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][3][1] = " & Form1.b26(1) & ";"
            End If
            If (Form1.b26(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][3][2] = " & Form1.b26(2) & ";"
            End If
            If (Form1.b25(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][3][0] = " & Form1.b25(0) & ";"
            End If
            If (Form1.b25(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][3][1] = " & Form1.b25(1) & ";"
            End If
            If (Form1.b25(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][3][2] = " & Form1.b25(2) & ";"
            End If
            If (Form1.b48(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][5][0] = " & Form1.b48(0) & ";"
            End If
            If (Form1.b48(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][5][1] = " & Form1.b48(1) & ";"
            End If
            If (Form1.b48(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][5][2] = " & Form1.b48(2) & ";"
            End If
            If (Form1.b47(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][5][0] = " & Form1.b47(0) & ";"
            End If
            If (Form1.b47(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][5][1] = " & Form1.b47(1) & ";"
            End If
            If (Form1.b47(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][5][2] = " & Form1.b47(2) & ";"
            End If
            If (Form1.b46(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][5][0] = " & Form1.b46(0) & ";"
            End If
            If (Form1.b46(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][5][1] = " & Form1.b46(1) & ";"
            End If
            If (Form1.b46(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][5][2] = " & Form1.b46(2) & ";"
            End If
            If (Form1.b45(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][5][0] = " & Form1.b45(0) & ";"
            End If
            If (Form1.b45(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][5][1] = " & Form1.b45(1) & ";"
            End If
            If (Form1.b45(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][5][2] = " & Form1.b45(2) & ";"
            End If
            If (Form1.b44(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][5][0] = " & Form1.b44(0) & ";"
            End If
            If (Form1.b44(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][5][1] = " & Form1.b44(1) & ";"
            End If
            If (Form1.b44(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][5][2] = " & Form1.b44(2) & ";"
            End If
            If (Form1.b43(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][5][0] = " & Form1.b43(0) & ";"
            End If
            If (Form1.b43(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][5][1] = " & Form1.b43(1) & ";"
            End If
            If (Form1.b43(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][5][2] = " & Form1.b43(2) & ";"
            End If
            If (Form1.b42(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][5][0] = " & Form1.b42(0) & ";"
            End If
            If (Form1.b42(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][5][1] = " & Form1.b42(1) & ";"
            End If
            If (Form1.b42(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][5][2] = " & Form1.b42(2) & ";"
            End If
            If (Form1.b41(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][5][0] = " & Form1.b41(0) & ";"
            End If
            If (Form1.b41(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][5][1] = " & Form1.b41(1) & ";"
            End If
            If (Form1.b41(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][5][2] = " & Form1.b41(2) & ";"
            End If
            If (Form1.b64(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][7][0] = " & Form1.b64(0) & ";"
            End If
            If (Form1.b64(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][7][1] = " & Form1.b64(1) & ";"
            End If
            If (Form1.b64(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][7][2] = " & Form1.b64(2) & ";"
            End If
            If (Form1.b63(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][7][0] = " & Form1.b63(0) & ";"
            End If
            If (Form1.b63(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][7][1] = " & Form1.b63(1) & ";"
            End If
            If (Form1.b63(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][7][2] = " & Form1.b63(2) & ";"
            End If
            If (Form1.b62(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][7][0] = " & Form1.b62(0) & ";"
            End If
            If (Form1.b62(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][7][1] = " & Form1.b62(1) & ";"
            End If
            If (Form1.b62(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][7][2] = " & Form1.b62(2) & ";"
            End If
            If (Form1.b61(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][7][0] = " & Form1.b61(0) & ";"
            End If
            If (Form1.b61(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][7][1] = " & Form1.b61(1) & ";"
            End If
            If (Form1.b61(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][7][2] = " & Form1.b61(2) & ";"
            End If
            If (Form1.b60(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][7][0] = " & Form1.b60(0) & ";"
            End If
            If (Form1.b60(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][7][1] = " & Form1.b60(1) & ";"
            End If
            If (Form1.b60(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][7][2] = " & Form1.b60(2) & ";"
            End If
            If (Form1.b59(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][7][0] = " & Form1.b59(0) & ";"
            End If
            If (Form1.b59(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][7][1] = " & Form1.b59(1) & ";"
            End If
            If (Form1.b59(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][7][2] = " & Form1.b59(2) & ";"
            End If
            If (Form1.b58(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][7][0] = " & Form1.b58(0) & ";"
            End If
            If (Form1.b58(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][7][1] = " & Form1.b58(1) & ";"
            End If
            If (Form1.b58(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][7][2] = " & Form1.b58(2) & ";"
            End If
            If (Form1.b57(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][7][0] = " & Form1.b57(0) & ";"
            End If
            If (Form1.b57(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][7][1] = " & Form1.b57(1) & ";"
            End If
            If (Form1.b57(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][7][2] = " & Form1.b57(2) & ";"
            End If
            If (Form1.b80(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][9][0] = " & Form1.b80(0) & ";"
            End If
            If (Form1.b80(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][9][1] = " & Form1.b80(1) & ";"
            End If
            If (Form1.b80(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][9][2] = " & Form1.b80(2) & ";"
            End If
            If (Form1.b79(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][9][0] = " & Form1.b79(0) & ";"
            End If
            If (Form1.b79(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][9][1] = " & Form1.b79(1) & ";"
            End If
            If (Form1.b79(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][9][2] = " & Form1.b79(2) & ";"
            End If
            If (Form1.b78(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][9][0] = " & Form1.b78(0) & ";"
            End If
            If (Form1.b78(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][9][1] = " & Form1.b78(1) & ";"
            End If
            If (Form1.b78(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][9][2] = " & Form1.b78(2) & ";"
            End If
            If (Form1.b77(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][9][0] = " & Form1.b77(0) & ";"
            End If
            If (Form1.b77(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][9][1] = " & Form1.b77(1) & ";"
            End If
            If (Form1.b77(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][9][2] = " & Form1.b77(2) & ";"
            End If
            If (Form1.b76(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][9][0] = " & Form1.b76(0) & ";"
            End If
            If (Form1.b76(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][9][1] = " & Form1.b76(1) & ";"
            End If
            If (Form1.b76(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][9][2] = " & Form1.b76(2) & ";"
            End If
            If (Form1.b75(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][9][0] = " & Form1.b75(0) & ";"
            End If
            If (Form1.b75(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][9][1] = " & Form1.b75(1) & ";"
            End If
            If (Form1.b75(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][9][2] = " & Form1.b75(2) & ";"
            End If
            If (Form1.b74(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][9][0] = " & Form1.b74(0) & ";"
            End If
            If (Form1.b74(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][9][1] = " & Form1.b74(1) & ";"
            End If
            If (Form1.b74(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][9][2] = " & Form1.b74(2) & ";"
            End If
            If (Form1.b73(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][9][0] = " & Form1.b73(0) & ";"
            End If
            If (Form1.b73(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][9][1] = " & Form1.b73(1) & ";"
            End If
            If (Form1.b73(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][9][2] = " & Form1.b73(2) & ";"
            End If
            If (Form1.b96(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][11][0] = " & Form1.b96(0) & ";"
            End If
            If (Form1.b96(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][11][1] = " & Form1.b96(1) & ";"
            End If
            If (Form1.b96(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][11][2] = " & Form1.b96(2) & ";"
            End If
            If (Form1.b95(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][11][0] = " & Form1.b95(0) & ";"
            End If
            If (Form1.b95(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][11][1] = " & Form1.b95(1) & ";"
            End If
            If (Form1.b95(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][11][2] = " & Form1.b95(2) & ";"
            End If
            If (Form1.b94(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][11][0] = " & Form1.b94(0) & ";"
            End If
            If (Form1.b94(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][11][1] = " & Form1.b94(1) & ";"
            End If
            If (Form1.b94(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][11][2] = " & Form1.b94(2) & ";"
            End If
            If (Form1.b93(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][11][0] = " & Form1.b93(0) & ";"
            End If
            If (Form1.b93(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][11][1] = " & Form1.b93(1) & ";"
            End If
            If (Form1.b93(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][11][2] = " & Form1.b93(2) & ";"
            End If
            If (Form1.b92(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][11][0] = " & Form1.b92(0) & ";"
            End If
            If (Form1.b92(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][11][1] = " & Form1.b92(1) & ";"
            End If
            If (Form1.b92(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][11][2] = " & Form1.b92(2) & ";"
            End If
            If (Form1.b91(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][11][0] = " & Form1.b91(0) & ";"
            End If
            If (Form1.b91(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][11][1] = " & Form1.b91(1) & ";"
            End If
            If (Form1.b91(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][11][2] = " & Form1.b91(2) & ";"
            End If
            If (Form1.b90(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][11][0] = " & Form1.b90(0) & ";"
            End If
            If (Form1.b90(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][11][1] = " & Form1.b90(1) & ";"
            End If
            If (Form1.b90(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][11][2] = " & Form1.b90(2) & ";"
            End If
            If (Form1.b89(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][11][0] = " & Form1.b89(0) & ";"
            End If
            If (Form1.b89(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][11][1] = " & Form1.b89(1) & ";"
            End If
            If (Form1.b89(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][11][2] = " & Form1.b89(2) & ";"
            End If
            If (Form1.b112(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][13][0] = " & Form1.b112(0) & ";"
            End If
            If (Form1.b112(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][13][1] = " & Form1.b112(1) & ";"
            End If
            If (Form1.b112(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][13][2] = " & Form1.b112(2) & ";"
            End If
            If (Form1.b111(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][13][0] = " & Form1.b111(0) & ";"
            End If
            If (Form1.b111(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][13][1] = " & Form1.b111(1) & ";"
            End If
            If (Form1.b111(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][13][2] = " & Form1.b111(2) & ";"
            End If
            If (Form1.b110(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][13][0] = " & Form1.b110(0) & ";"
            End If
            If (Form1.b110(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][13][1] = " & Form1.b110(1) & ";"
            End If
            If (Form1.b110(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][13][2] = " & Form1.b110(2) & ";"
            End If
            If (Form1.b109(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][13][0] = " & Form1.b109(0) & ";"
            End If
            If (Form1.b109(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][13][1] = " & Form1.b109(1) & ";"
            End If
            If (Form1.b109(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][13][2] = " & Form1.b109(2) & ";"
            End If
            If (Form1.b108(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][13][0] = " & Form1.b108(0) & ";"
            End If
            If (Form1.b108(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][13][1] = " & Form1.b108(1) & ";"
            End If
            If (Form1.b108(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][13][2] = " & Form1.b108(2) & ";"
            End If
            If (Form1.b107(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][13][0] = " & Form1.b107(0) & ";"
            End If
            If (Form1.b107(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][13][1] = " & Form1.b107(1) & ";"
            End If
            If (Form1.b107(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][13][2] = " & Form1.b107(2) & ";"
            End If
            If (Form1.b106(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][13][0] = " & Form1.b106(0) & ";"
            End If
            If (Form1.b106(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][13][1] = " & Form1.b106(1) & ";"
            End If
            If (Form1.b106(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][13][2] = " & Form1.b106(2) & ";"
            End If
            If (Form1.b105(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][13][0] = " & Form1.b105(0) & ";"
            End If
            If (Form1.b105(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][13][1] = " & Form1.b105(1) & ";"
            End If
            If (Form1.b105(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][13][2] = " & Form1.b105(2) & ";"
            End If
            If (Form1.b128(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][15][0] = " & Form1.b128(0) & ";"
            End If
            If (Form1.b128(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][15][1] = " & Form1.b128(1) & ";"
            End If
            If (Form1.b128(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][15][2] = " & Form1.b128(2) & ";"
            End If
            If (Form1.b127(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][15][0] = " & Form1.b127(0) & ";"
            End If
            If (Form1.b127(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][15][1] = " & Form1.b127(1) & ";"
            End If
            If (Form1.b127(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][15][2] = " & Form1.b127(2) & ";"
            End If
            If (Form1.b126(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][15][0] = " & Form1.b126(0) & ";"
            End If
            If (Form1.b126(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][15][1] = " & Form1.b126(1) & ";"
            End If
            If (Form1.b126(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][15][2] = " & Form1.b126(2) & ";"
            End If
            If (Form1.b125(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][15][0] = " & Form1.b125(0) & ";"
            End If
            If (Form1.b125(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][15][1] = " & Form1.b125(1) & ";"
            End If
            If (Form1.b125(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][15][2] = " & Form1.b125(2) & ";"
            End If
            If (Form1.b124(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][15][0] = " & Form1.b124(0) & ";"
            End If
            If (Form1.b124(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][15][1] = " & Form1.b124(1) & ";"
            End If
            If (Form1.b124(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][15][2] = " & Form1.b124(2) & ";"
            End If
            If (Form1.b123(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][15][0] = " & Form1.b123(0) & ";"
            End If
            If (Form1.b123(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][15][1] = " & Form1.b123(1) & ";"
            End If
            If (Form1.b123(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][15][2] = " & Form1.b123(2) & ";"
            End If
            If (Form1.b122(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][15][0] = " & Form1.b122(0) & ";"
            End If
            If (Form1.b122(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][15][1] = " & Form1.b122(1) & ";"
            End If
            If (Form1.b122(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][15][2] = " & Form1.b122(2) & ";"
            End If
            If (Form1.b121(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][15][0] = " & Form1.b121(0) & ";"
            End If
            If (Form1.b121(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][15][1] = " & Form1.b121(1) & ";"
            End If
            If (Form1.b121(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][15][2] = " & Form1.b121(2) & ";"
            End If
            If (Form1.b144(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][17][0] = " & Form1.b144(0) & ";"
            End If
            If (Form1.b144(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][17][1] = " & Form1.b144(1) & ";"
            End If
            If (Form1.b144(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][17][2] = " & Form1.b144(2) & ";"
            End If
            If (Form1.b143(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][17][0] = " & Form1.b143(0) & ";"
            End If
            If (Form1.b143(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][17][1] = " & Form1.b143(1) & ";"
            End If
            If (Form1.b143(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][17][2] = " & Form1.b143(2) & ";"
            End If
            If (Form1.b142(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][17][0] = " & Form1.b142(0) & ";"
            End If
            If (Form1.b142(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][17][1] = " & Form1.b142(1) & ";"
            End If
            If (Form1.b142(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][17][2] = " & Form1.b142(2) & ";"
            End If
            If (Form1.b141(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][17][0] = " & Form1.b141(0) & ";"
            End If
            If (Form1.b141(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][17][1] = " & Form1.b141(1) & ";"
            End If
            If (Form1.b141(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][17][2] = " & Form1.b141(2) & ";"
            End If
            If (Form1.b140(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][17][0] = " & Form1.b140(0) & ";"
            End If
            If (Form1.b140(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][17][1] = " & Form1.b140(1) & ";"
            End If
            If (Form1.b140(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][17][2] = " & Form1.b140(2) & ";"
            End If
            If (Form1.b139(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][17][0] = " & Form1.b139(0) & ";"
            End If
            If (Form1.b139(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][17][1] = " & Form1.b139(1) & ";"
            End If
            If (Form1.b139(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][17][2] = " & Form1.b139(2) & ";"
            End If
            If (Form1.b138(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][17][0] = " & Form1.b138(0) & ";"
            End If
            If (Form1.b138(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][17][1] = " & Form1.b138(1) & ";"
            End If
            If (Form1.b138(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][17][2] = " & Form1.b138(2) & ";"
            End If
            If (Form1.b137(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][17][0] = " & Form1.b137(0) & ";"
            End If
            If (Form1.b137(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][17][1] = " & Form1.b137(1) & ";"
            End If
            If (Form1.b137(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][17][2] = " & Form1.b137(2) & ";"
            End If
            If (Form1.b160(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][19][0] = " & Form1.b160(0) & ";"
            End If
            If (Form1.b160(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][19][1] = " & Form1.b160(1) & ";"
            End If
            If (Form1.b160(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][19][2] = " & Form1.b160(2) & ";"
            End If
            If (Form1.b159(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][19][0] = " & Form1.b159(0) & ";"
            End If
            If (Form1.b159(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][19][1] = " & Form1.b159(1) & ";"
            End If
            If (Form1.b159(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][19][2] = " & Form1.b159(2) & ";"
            End If
            If (Form1.b158(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][19][0] = " & Form1.b158(0) & ";"
            End If
            If (Form1.b158(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][19][1] = " & Form1.b158(1) & ";"
            End If
            If (Form1.b158(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][19][2] = " & Form1.b158(2) & ";"
            End If
            If (Form1.b157(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][19][0] = " & Form1.b157(0) & ";"
            End If
            If (Form1.b157(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][19][1] = " & Form1.b157(1) & ";"
            End If
            If (Form1.b157(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][19][2] = " & Form1.b157(2) & ";"
            End If
            If (Form1.b156(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][19][0] = " & Form1.b156(0) & ";"
            End If
            If (Form1.b156(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][19][1] = " & Form1.b156(1) & ";"
            End If
            If (Form1.b156(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][19][2] = " & Form1.b156(2) & ";"
            End If
            If (Form1.b155(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][19][0] = " & Form1.b155(0) & ";"
            End If
            If (Form1.b155(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][19][1] = " & Form1.b155(1) & ";"
            End If
            If (Form1.b155(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][19][2] = " & Form1.b155(2) & ";"
            End If
            If (Form1.b154(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][19][0] = " & Form1.b154(0) & ";"
            End If
            If (Form1.b154(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][19][1] = " & Form1.b154(1) & ";"
            End If
            If (Form1.b154(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][19][2] = " & Form1.b154(2) & ";"
            End If
            If (Form1.b153(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][19][0] = " & Form1.b153(0) & ";"
            End If
            If (Form1.b153(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][19][1] = " & Form1.b153(1) & ";"
            End If
            If (Form1.b153(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][19][2] = " & Form1.b153(2) & ";"
            End If
            If (Form1.b176(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][21][0] = " & Form1.b176(0) & ";"
            End If
            If (Form1.b176(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][21][1] = " & Form1.b176(1) & ";"
            End If
            If (Form1.b176(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][21][2] = " & Form1.b176(2) & ";"
            End If
            If (Form1.b175(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][21][0] = " & Form1.b175(0) & ";"
            End If
            If (Form1.b175(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][21][1] = " & Form1.b175(1) & ";"
            End If
            If (Form1.b175(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][21][2] = " & Form1.b175(2) & ";"
            End If
            If (Form1.b174(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][21][0] = " & Form1.b174(0) & ";"
            End If
            If (Form1.b174(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][21][1] = " & Form1.b174(1) & ";"
            End If
            If (Form1.b174(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][21][2] = " & Form1.b174(2) & ";"
            End If
            If (Form1.b173(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][21][0] = " & Form1.b173(0) & ";"
            End If
            If (Form1.b173(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][21][1] = " & Form1.b173(1) & ";"
            End If
            If (Form1.b173(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][21][2] = " & Form1.b173(2) & ";"
            End If
            If (Form1.b172(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][21][0] = " & Form1.b172(0) & ";"
            End If
            If (Form1.b172(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][21][1] = " & Form1.b172(1) & ";"
            End If
            If (Form1.b172(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][21][2] = " & Form1.b172(2) & ";"
            End If
            If (Form1.b171(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][21][0] = " & Form1.b171(0) & ";"
            End If
            If (Form1.b171(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][21][1] = " & Form1.b171(1) & ";"
            End If
            If (Form1.b171(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][21][2] = " & Form1.b171(2) & ";"
            End If
            If (Form1.b170(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][21][0] = " & Form1.b170(0) & ";"
            End If
            If (Form1.b170(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][21][1] = " & Form1.b170(1) & ";"
            End If
            If (Form1.b170(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][21][2] = " & Form1.b170(2) & ";"
            End If
            If (Form1.b169(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][21][0] = " & Form1.b169(0) & ";"
            End If
            If (Form1.b169(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][21][1] = " & Form1.b169(1) & ";"
            End If
            If (Form1.b169(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][21][2] = " & Form1.b169(2) & ";"
            End If
            If (Form1.b192(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][23][0] = " & Form1.b192(0) & ";"
            End If
            If (Form1.b192(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][23][1] = " & Form1.b192(1) & ";"
            End If
            If (Form1.b192(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[0][23][2] = " & Form1.b192(2) & ";"
            End If
            If (Form1.b191(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][23][0] = " & Form1.b191(0) & ";"
            End If
            If (Form1.b191(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][23][1] = " & Form1.b191(1) & ";"
            End If
            If (Form1.b191(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[1][23][2] = " & Form1.b191(2) & ";"
            End If
            If (Form1.b190(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][23][0] = " & Form1.b190(0) & ";"
            End If
            If (Form1.b190(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][23][1] = " & Form1.b190(1) & ";"
            End If
            If (Form1.b190(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[2][23][2] = " & Form1.b190(2) & ";"
            End If
            If (Form1.b189(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][23][0] = " & Form1.b189(0) & ";"
            End If
            If (Form1.b189(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][23][1] = " & Form1.b189(1) & ";"
            End If
            If (Form1.b189(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[3][23][2] = " & Form1.b189(2) & ";"
            End If
            If (Form1.b188(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][23][0] = " & Form1.b188(0) & ";"
            End If
            If (Form1.b188(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][23][1] = " & Form1.b188(1) & ";"
            End If
            If (Form1.b188(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[4][23][2] = " & Form1.b188(2) & ";"
            End If
            If (Form1.b187(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][23][0] = " & Form1.b187(0) & ";"
            End If
            If (Form1.b187(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][23][1] = " & Form1.b187(1) & ";"
            End If
            If (Form1.b187(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[5][23][2] = " & Form1.b187(2) & ";"
            End If
            If (Form1.b186(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][23][0] = " & Form1.b186(0) & ";"
            End If
            If (Form1.b186(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][23][1] = " & Form1.b186(1) & ";"
            End If
            If (Form1.b186(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[6][23][2] = " & Form1.b186(2) & ";"
            End If
            If (Form1.b185(0) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][23][0] = " & Form1.b185(0) & ";"
            End If
            If (Form1.b185(1) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][23][1] = " & Form1.b185(1) & ";"
            End If
            If (Form1.b185(2) <> 0) Then
                F.Text = F.Text & vbNewLine & "  " & Form1.TextBox2.Text & "[7][23][2] = " & Form1.b185(2) & ";"
            End If


            F.Text = F.Text & vbNewLine & "}"
            F.Text = F.Text & vbNewLine & ""
            F.Text = F.Text & vbNewLine & ""







        Else
            F.Text = "void " & Form1.TextBox1.Text & "(int sp, int rep) {"
            F.Text = F.Text & vbNewLine & "  FastLED.clear();"
            F.Text = F.Text & vbNewLine & "  for (int i = 0; i < rep; i++) {"

            Dim y As Long = 0
            For y = 0 To Form1.NumericUpDown1.Value - 1
                If (y = 0) Then
                    Dim yy As Integer
                    For yy = 0 To 199
                        If (Form1.framesR(yy) <> 0 Or Form1.framesG(yy) <> 0 Or Form1.framesB(yy) <> 0) Then
                            F.Text = F.Text & vbNewLine & "    leds[" & yy & "] = CRGB(" & Form1.framesR(yy) & ", " & Form1.framesG(yy) & ", " & Form1.framesB(yy) & ");"
                        End If
                    Next
                    F.Text = F.Text & vbNewLine & "    FastLED.show();"
                    F.Text = F.Text & vbNewLine & "    delay(sp);"
                Else
                    Dim yy As Integer
                    For yy = y * 200 To (y * 200) + 199
                        If (Form1.framesR(yy) <> Form1.framesR(yy - 200) Or Form1.framesG(yy) <> Form1.framesG(yy - 200) Or Form1.framesB(yy) <> Form1.framesB(yy - 200)) Then
                            F.Text = F.Text & vbNewLine & "    leds[" & yy - (y * 200) & "] = CRGB(" & Form1.framesR(yy) & ", " & Form1.framesG(yy) & ", " & Form1.framesB(yy) & ");"
                        End If
                    Next
                    F.Text = F.Text & vbNewLine & "    FastLED.show();"
                    F.Text = F.Text & vbNewLine & "    delay(sp);"
                End If
            Next
            F.Text = F.Text & vbNewLine & "  }"
            F.Text = F.Text & vbNewLine & "}"
            F.Text = F.Text & vbNewLine & ""
            F.Text = F.Text & vbNewLine & ""

        End If

        
    End Sub
End Class