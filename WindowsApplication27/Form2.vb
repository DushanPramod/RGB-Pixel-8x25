Public Class Form2
    Dim x As Integer
    Dim sel As Integer


    Dim co1(24) As Color
    Dim co2(24) As Color
    Dim co3(24) As Color
    Dim co4(24) As Color
    Dim co5(24) As Color
    Dim co6(24) As Color
    Dim co7(24) As Color
    Dim co8(24) As Color


    Private Sub Button290_Click(sender As Object, e As EventArgs) Handles Button290.Click

        x = 0
        Timer1.Start()



    End Sub

    Private Sub Button291_Click(sender As Object, e As EventArgs) Handles Button291.Click
        Timer1.Stop()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        sel = 1
        Button1.BackColor = Color.Red

        Timer1.Stop()

        Label1.Text = TrackBar1.Value * 100
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Label1.Text = TrackBar1.Value * 100
        Timer1.Interval = TrackBar1.Value * 100
    End Sub
    Sub run(i As Long)
        OvalShape1.FillColor = Color.FromArgb(255, Form1.framesR(i + 0), Form1.framesG(i + 0), Form1.framesB(i + 0))
        OvalShape2.FillColor = Color.FromArgb(255, Form1.framesR(i + 1), Form1.framesG(i + 1), Form1.framesB(i + 1))
        OvalShape3.FillColor = Color.FromArgb(255, Form1.framesR(i + 2), Form1.framesG(i + 2), Form1.framesB(i + 2))
        OvalShape4.FillColor = Color.FromArgb(255, Form1.framesR(i + 3), Form1.framesG(i + 3), Form1.framesB(i + 3))
        OvalShape5.FillColor = Color.FromArgb(255, Form1.framesR(i + 4), Form1.framesG(i + 4), Form1.framesB(i + 4))
        OvalShape6.FillColor = Color.FromArgb(255, Form1.framesR(i + 5), Form1.framesG(i + 5), Form1.framesB(i + 5))
        OvalShape7.FillColor = Color.FromArgb(255, Form1.framesR(i + 6), Form1.framesG(i + 6), Form1.framesB(i + 6))
        OvalShape8.FillColor = Color.FromArgb(255, Form1.framesR(i + 7), Form1.framesG(i + 7), Form1.framesB(i + 7))
        OvalShape9.FillColor = Color.FromArgb(255, Form1.framesR(i + 8), Form1.framesG(i + 8), Form1.framesB(i + 8))
        OvalShape10.FillColor = Color.FromArgb(255, Form1.framesR(i + 9), Form1.framesG(i + 9), Form1.framesB(i + 9))
        OvalShape11.FillColor = Color.FromArgb(255, Form1.framesR(i + 10), Form1.framesG(i + 10), Form1.framesB(i + 10))
        OvalShape12.FillColor = Color.FromArgb(255, Form1.framesR(i + 11), Form1.framesG(i + 11), Form1.framesB(i + 11))
        OvalShape13.FillColor = Color.FromArgb(255, Form1.framesR(i + 12), Form1.framesG(i + 12), Form1.framesB(i + 12))
        OvalShape14.FillColor = Color.FromArgb(255, Form1.framesR(i + 13), Form1.framesG(i + 13), Form1.framesB(i + 13))
        OvalShape15.FillColor = Color.FromArgb(255, Form1.framesR(i + 14), Form1.framesG(i + 14), Form1.framesB(i + 14))
        OvalShape16.FillColor = Color.FromArgb(255, Form1.framesR(i + 15), Form1.framesG(i + 15), Form1.framesB(i + 15))
        OvalShape17.FillColor = Color.FromArgb(255, Form1.framesR(i + 16), Form1.framesG(i + 16), Form1.framesB(i + 16))
        OvalShape18.FillColor = Color.FromArgb(255, Form1.framesR(i + 17), Form1.framesG(i + 17), Form1.framesB(i + 17))
        OvalShape19.FillColor = Color.FromArgb(255, Form1.framesR(i + 18), Form1.framesG(i + 18), Form1.framesB(i + 18))
        OvalShape20.FillColor = Color.FromArgb(255, Form1.framesR(i + 19), Form1.framesG(i + 19), Form1.framesB(i + 19))
        OvalShape21.FillColor = Color.FromArgb(255, Form1.framesR(i + 20), Form1.framesG(i + 20), Form1.framesB(i + 20))
        OvalShape22.FillColor = Color.FromArgb(255, Form1.framesR(i + 21), Form1.framesG(i + 21), Form1.framesB(i + 21))
        OvalShape23.FillColor = Color.FromArgb(255, Form1.framesR(i + 22), Form1.framesG(i + 22), Form1.framesB(i + 22))
        OvalShape24.FillColor = Color.FromArgb(255, Form1.framesR(i + 23), Form1.framesG(i + 23), Form1.framesB(i + 23))
        OvalShape25.FillColor = Color.FromArgb(255, Form1.framesR(i + 24), Form1.framesG(i + 24), Form1.framesB(i + 24))
        OvalShape26.FillColor = Color.FromArgb(255, Form1.framesR(i + 25), Form1.framesG(i + 25), Form1.framesB(i + 25))
        OvalShape27.FillColor = Color.FromArgb(255, Form1.framesR(i + 26), Form1.framesG(i + 26), Form1.framesB(i + 26))
        OvalShape28.FillColor = Color.FromArgb(255, Form1.framesR(i + 27), Form1.framesG(i + 27), Form1.framesB(i + 27))
        OvalShape29.FillColor = Color.FromArgb(255, Form1.framesR(i + 28), Form1.framesG(i + 28), Form1.framesB(i + 28))
        OvalShape30.FillColor = Color.FromArgb(255, Form1.framesR(i + 29), Form1.framesG(i + 29), Form1.framesB(i + 29))
        OvalShape31.FillColor = Color.FromArgb(255, Form1.framesR(i + 30), Form1.framesG(i + 30), Form1.framesB(i + 30))
        OvalShape32.FillColor = Color.FromArgb(255, Form1.framesR(i + 31), Form1.framesG(i + 31), Form1.framesB(i + 31))
        OvalShape33.FillColor = Color.FromArgb(255, Form1.framesR(i + 32), Form1.framesG(i + 32), Form1.framesB(i + 32))
        OvalShape34.FillColor = Color.FromArgb(255, Form1.framesR(i + 33), Form1.framesG(i + 33), Form1.framesB(i + 33))
        OvalShape35.FillColor = Color.FromArgb(255, Form1.framesR(i + 34), Form1.framesG(i + 34), Form1.framesB(i + 34))
        OvalShape36.FillColor = Color.FromArgb(255, Form1.framesR(i + 35), Form1.framesG(i + 35), Form1.framesB(i + 35))
        OvalShape37.FillColor = Color.FromArgb(255, Form1.framesR(i + 36), Form1.framesG(i + 36), Form1.framesB(i + 36))
        OvalShape38.FillColor = Color.FromArgb(255, Form1.framesR(i + 37), Form1.framesG(i + 37), Form1.framesB(i + 37))
        OvalShape39.FillColor = Color.FromArgb(255, Form1.framesR(i + 38), Form1.framesG(i + 38), Form1.framesB(i + 38))
        OvalShape40.FillColor = Color.FromArgb(255, Form1.framesR(i + 39), Form1.framesG(i + 39), Form1.framesB(i + 39))
        OvalShape41.FillColor = Color.FromArgb(255, Form1.framesR(i + 40), Form1.framesG(i + 40), Form1.framesB(i + 40))
        OvalShape42.FillColor = Color.FromArgb(255, Form1.framesR(i + 41), Form1.framesG(i + 41), Form1.framesB(i + 41))
        OvalShape43.FillColor = Color.FromArgb(255, Form1.framesR(i + 42), Form1.framesG(i + 42), Form1.framesB(i + 42))
        OvalShape44.FillColor = Color.FromArgb(255, Form1.framesR(i + 43), Form1.framesG(i + 43), Form1.framesB(i + 43))
        OvalShape45.FillColor = Color.FromArgb(255, Form1.framesR(i + 44), Form1.framesG(i + 44), Form1.framesB(i + 44))
        OvalShape46.FillColor = Color.FromArgb(255, Form1.framesR(i + 45), Form1.framesG(i + 45), Form1.framesB(i + 45))
        OvalShape47.FillColor = Color.FromArgb(255, Form1.framesR(i + 46), Form1.framesG(i + 46), Form1.framesB(i + 46))
        OvalShape48.FillColor = Color.FromArgb(255, Form1.framesR(i + 47), Form1.framesG(i + 47), Form1.framesB(i + 47))
        OvalShape49.FillColor = Color.FromArgb(255, Form1.framesR(i + 48), Form1.framesG(i + 48), Form1.framesB(i + 48))
        OvalShape50.FillColor = Color.FromArgb(255, Form1.framesR(i + 49), Form1.framesG(i + 49), Form1.framesB(i + 49))
        OvalShape51.FillColor = Color.FromArgb(255, Form1.framesR(i + 50), Form1.framesG(i + 50), Form1.framesB(i + 50))
        OvalShape52.FillColor = Color.FromArgb(255, Form1.framesR(i + 51), Form1.framesG(i + 51), Form1.framesB(i + 51))
        OvalShape53.FillColor = Color.FromArgb(255, Form1.framesR(i + 52), Form1.framesG(i + 52), Form1.framesB(i + 52))
        OvalShape54.FillColor = Color.FromArgb(255, Form1.framesR(i + 53), Form1.framesG(i + 53), Form1.framesB(i + 53))
        OvalShape55.FillColor = Color.FromArgb(255, Form1.framesR(i + 54), Form1.framesG(i + 54), Form1.framesB(i + 54))
        OvalShape56.FillColor = Color.FromArgb(255, Form1.framesR(i + 55), Form1.framesG(i + 55), Form1.framesB(i + 55))
        OvalShape57.FillColor = Color.FromArgb(255, Form1.framesR(i + 56), Form1.framesG(i + 56), Form1.framesB(i + 56))
        OvalShape58.FillColor = Color.FromArgb(255, Form1.framesR(i + 57), Form1.framesG(i + 57), Form1.framesB(i + 57))
        OvalShape59.FillColor = Color.FromArgb(255, Form1.framesR(i + 58), Form1.framesG(i + 58), Form1.framesB(i + 58))
        OvalShape60.FillColor = Color.FromArgb(255, Form1.framesR(i + 59), Form1.framesG(i + 59), Form1.framesB(i + 59))
        OvalShape61.FillColor = Color.FromArgb(255, Form1.framesR(i + 60), Form1.framesG(i + 60), Form1.framesB(i + 60))
        OvalShape62.FillColor = Color.FromArgb(255, Form1.framesR(i + 61), Form1.framesG(i + 61), Form1.framesB(i + 61))
        OvalShape63.FillColor = Color.FromArgb(255, Form1.framesR(i + 62), Form1.framesG(i + 62), Form1.framesB(i + 62))
        OvalShape64.FillColor = Color.FromArgb(255, Form1.framesR(i + 63), Form1.framesG(i + 63), Form1.framesB(i + 63))
        OvalShape65.FillColor = Color.FromArgb(255, Form1.framesR(i + 64), Form1.framesG(i + 64), Form1.framesB(i + 64))
        OvalShape66.FillColor = Color.FromArgb(255, Form1.framesR(i + 65), Form1.framesG(i + 65), Form1.framesB(i + 65))
        OvalShape67.FillColor = Color.FromArgb(255, Form1.framesR(i + 66), Form1.framesG(i + 66), Form1.framesB(i + 66))
        OvalShape68.FillColor = Color.FromArgb(255, Form1.framesR(i + 67), Form1.framesG(i + 67), Form1.framesB(i + 67))
        OvalShape69.FillColor = Color.FromArgb(255, Form1.framesR(i + 68), Form1.framesG(i + 68), Form1.framesB(i + 68))
        OvalShape70.FillColor = Color.FromArgb(255, Form1.framesR(i + 69), Form1.framesG(i + 69), Form1.framesB(i + 69))
        OvalShape71.FillColor = Color.FromArgb(255, Form1.framesR(i + 70), Form1.framesG(i + 70), Form1.framesB(i + 70))
        OvalShape72.FillColor = Color.FromArgb(255, Form1.framesR(i + 71), Form1.framesG(i + 71), Form1.framesB(i + 71))
        OvalShape73.FillColor = Color.FromArgb(255, Form1.framesR(i + 72), Form1.framesG(i + 72), Form1.framesB(i + 72))
        OvalShape74.FillColor = Color.FromArgb(255, Form1.framesR(i + 73), Form1.framesG(i + 73), Form1.framesB(i + 73))
        OvalShape75.FillColor = Color.FromArgb(255, Form1.framesR(i + 74), Form1.framesG(i + 74), Form1.framesB(i + 74))
        OvalShape76.FillColor = Color.FromArgb(255, Form1.framesR(i + 75), Form1.framesG(i + 75), Form1.framesB(i + 75))
        OvalShape77.FillColor = Color.FromArgb(255, Form1.framesR(i + 76), Form1.framesG(i + 76), Form1.framesB(i + 76))
        OvalShape78.FillColor = Color.FromArgb(255, Form1.framesR(i + 77), Form1.framesG(i + 77), Form1.framesB(i + 77))
        OvalShape79.FillColor = Color.FromArgb(255, Form1.framesR(i + 78), Form1.framesG(i + 78), Form1.framesB(i + 78))
        OvalShape80.FillColor = Color.FromArgb(255, Form1.framesR(i + 79), Form1.framesG(i + 79), Form1.framesB(i + 79))
        OvalShape81.FillColor = Color.FromArgb(255, Form1.framesR(i + 80), Form1.framesG(i + 80), Form1.framesB(i + 80))
        OvalShape82.FillColor = Color.FromArgb(255, Form1.framesR(i + 81), Form1.framesG(i + 81), Form1.framesB(i + 81))
        OvalShape83.FillColor = Color.FromArgb(255, Form1.framesR(i + 82), Form1.framesG(i + 82), Form1.framesB(i + 82))
        OvalShape84.FillColor = Color.FromArgb(255, Form1.framesR(i + 83), Form1.framesG(i + 83), Form1.framesB(i + 83))
        OvalShape85.FillColor = Color.FromArgb(255, Form1.framesR(i + 84), Form1.framesG(i + 84), Form1.framesB(i + 84))
        OvalShape86.FillColor = Color.FromArgb(255, Form1.framesR(i + 85), Form1.framesG(i + 85), Form1.framesB(i + 85))
        OvalShape87.FillColor = Color.FromArgb(255, Form1.framesR(i + 86), Form1.framesG(i + 86), Form1.framesB(i + 86))
        OvalShape88.FillColor = Color.FromArgb(255, Form1.framesR(i + 87), Form1.framesG(i + 87), Form1.framesB(i + 87))
        OvalShape89.FillColor = Color.FromArgb(255, Form1.framesR(i + 88), Form1.framesG(i + 88), Form1.framesB(i + 88))
        OvalShape90.FillColor = Color.FromArgb(255, Form1.framesR(i + 89), Form1.framesG(i + 89), Form1.framesB(i + 89))
        OvalShape91.FillColor = Color.FromArgb(255, Form1.framesR(i + 90), Form1.framesG(i + 90), Form1.framesB(i + 90))
        OvalShape92.FillColor = Color.FromArgb(255, Form1.framesR(i + 91), Form1.framesG(i + 91), Form1.framesB(i + 91))
        OvalShape93.FillColor = Color.FromArgb(255, Form1.framesR(i + 92), Form1.framesG(i + 92), Form1.framesB(i + 92))
        OvalShape94.FillColor = Color.FromArgb(255, Form1.framesR(i + 93), Form1.framesG(i + 93), Form1.framesB(i + 93))
        OvalShape95.FillColor = Color.FromArgb(255, Form1.framesR(i + 94), Form1.framesG(i + 94), Form1.framesB(i + 94))
        OvalShape96.FillColor = Color.FromArgb(255, Form1.framesR(i + 95), Form1.framesG(i + 95), Form1.framesB(i + 95))
        OvalShape97.FillColor = Color.FromArgb(255, Form1.framesR(i + 96), Form1.framesG(i + 96), Form1.framesB(i + 96))
        OvalShape98.FillColor = Color.FromArgb(255, Form1.framesR(i + 97), Form1.framesG(i + 97), Form1.framesB(i + 97))
        OvalShape99.FillColor = Color.FromArgb(255, Form1.framesR(i + 98), Form1.framesG(i + 98), Form1.framesB(i + 98))
        OvalShape100.FillColor = Color.FromArgb(255, Form1.framesR(i + 99), Form1.framesG(i + 99), Form1.framesB(i + 99))
        OvalShape101.FillColor = Color.FromArgb(255, Form1.framesR(i + 100), Form1.framesG(i + 100), Form1.framesB(i + 100))
        OvalShape102.FillColor = Color.FromArgb(255, Form1.framesR(i + 101), Form1.framesG(i + 101), Form1.framesB(i + 101))
        OvalShape103.FillColor = Color.FromArgb(255, Form1.framesR(i + 102), Form1.framesG(i + 102), Form1.framesB(i + 102))
        OvalShape104.FillColor = Color.FromArgb(255, Form1.framesR(i + 103), Form1.framesG(i + 103), Form1.framesB(i + 103))
        OvalShape105.FillColor = Color.FromArgb(255, Form1.framesR(i + 104), Form1.framesG(i + 104), Form1.framesB(i + 104))
        OvalShape106.FillColor = Color.FromArgb(255, Form1.framesR(i + 105), Form1.framesG(i + 105), Form1.framesB(i + 105))
        OvalShape107.FillColor = Color.FromArgb(255, Form1.framesR(i + 106), Form1.framesG(i + 106), Form1.framesB(i + 106))
        OvalShape108.FillColor = Color.FromArgb(255, Form1.framesR(i + 107), Form1.framesG(i + 107), Form1.framesB(i + 107))
        OvalShape109.FillColor = Color.FromArgb(255, Form1.framesR(i + 108), Form1.framesG(i + 108), Form1.framesB(i + 108))
        OvalShape110.FillColor = Color.FromArgb(255, Form1.framesR(i + 109), Form1.framesG(i + 109), Form1.framesB(i + 109))
        OvalShape111.FillColor = Color.FromArgb(255, Form1.framesR(i + 110), Form1.framesG(i + 110), Form1.framesB(i + 110))
        OvalShape112.FillColor = Color.FromArgb(255, Form1.framesR(i + 111), Form1.framesG(i + 111), Form1.framesB(i + 111))
        OvalShape113.FillColor = Color.FromArgb(255, Form1.framesR(i + 112), Form1.framesG(i + 112), Form1.framesB(i + 112))
        OvalShape114.FillColor = Color.FromArgb(255, Form1.framesR(i + 113), Form1.framesG(i + 113), Form1.framesB(i + 113))
        OvalShape115.FillColor = Color.FromArgb(255, Form1.framesR(i + 114), Form1.framesG(i + 114), Form1.framesB(i + 114))
        OvalShape116.FillColor = Color.FromArgb(255, Form1.framesR(i + 115), Form1.framesG(i + 115), Form1.framesB(i + 115))
        OvalShape117.FillColor = Color.FromArgb(255, Form1.framesR(i + 116), Form1.framesG(i + 116), Form1.framesB(i + 116))
        OvalShape118.FillColor = Color.FromArgb(255, Form1.framesR(i + 117), Form1.framesG(i + 117), Form1.framesB(i + 117))
        OvalShape119.FillColor = Color.FromArgb(255, Form1.framesR(i + 118), Form1.framesG(i + 118), Form1.framesB(i + 118))
        OvalShape120.FillColor = Color.FromArgb(255, Form1.framesR(i + 119), Form1.framesG(i + 119), Form1.framesB(i + 119))
        OvalShape121.FillColor = Color.FromArgb(255, Form1.framesR(i + 120), Form1.framesG(i + 120), Form1.framesB(i + 120))
        OvalShape122.FillColor = Color.FromArgb(255, Form1.framesR(i + 121), Form1.framesG(i + 121), Form1.framesB(i + 121))
        OvalShape123.FillColor = Color.FromArgb(255, Form1.framesR(i + 122), Form1.framesG(i + 122), Form1.framesB(i + 122))
        OvalShape124.FillColor = Color.FromArgb(255, Form1.framesR(i + 123), Form1.framesG(i + 123), Form1.framesB(i + 123))
        OvalShape125.FillColor = Color.FromArgb(255, Form1.framesR(i + 124), Form1.framesG(i + 124), Form1.framesB(i + 124))
        OvalShape126.FillColor = Color.FromArgb(255, Form1.framesR(i + 125), Form1.framesG(i + 125), Form1.framesB(i + 125))
        OvalShape127.FillColor = Color.FromArgb(255, Form1.framesR(i + 126), Form1.framesG(i + 126), Form1.framesB(i + 126))
        OvalShape128.FillColor = Color.FromArgb(255, Form1.framesR(i + 127), Form1.framesG(i + 127), Form1.framesB(i + 127))
        OvalShape129.FillColor = Color.FromArgb(255, Form1.framesR(i + 128), Form1.framesG(i + 128), Form1.framesB(i + 128))
        OvalShape130.FillColor = Color.FromArgb(255, Form1.framesR(i + 129), Form1.framesG(i + 129), Form1.framesB(i + 129))
        OvalShape131.FillColor = Color.FromArgb(255, Form1.framesR(i + 130), Form1.framesG(i + 130), Form1.framesB(i + 130))
        OvalShape132.FillColor = Color.FromArgb(255, Form1.framesR(i + 131), Form1.framesG(i + 131), Form1.framesB(i + 131))
        OvalShape133.FillColor = Color.FromArgb(255, Form1.framesR(i + 132), Form1.framesG(i + 132), Form1.framesB(i + 132))
        OvalShape134.FillColor = Color.FromArgb(255, Form1.framesR(i + 133), Form1.framesG(i + 133), Form1.framesB(i + 133))
        OvalShape135.FillColor = Color.FromArgb(255, Form1.framesR(i + 134), Form1.framesG(i + 134), Form1.framesB(i + 134))
        OvalShape136.FillColor = Color.FromArgb(255, Form1.framesR(i + 135), Form1.framesG(i + 135), Form1.framesB(i + 135))
        OvalShape137.FillColor = Color.FromArgb(255, Form1.framesR(i + 136), Form1.framesG(i + 136), Form1.framesB(i + 136))
        OvalShape138.FillColor = Color.FromArgb(255, Form1.framesR(i + 137), Form1.framesG(i + 137), Form1.framesB(i + 137))
        OvalShape139.FillColor = Color.FromArgb(255, Form1.framesR(i + 138), Form1.framesG(i + 138), Form1.framesB(i + 138))
        OvalShape140.FillColor = Color.FromArgb(255, Form1.framesR(i + 139), Form1.framesG(i + 139), Form1.framesB(i + 139))
        OvalShape141.FillColor = Color.FromArgb(255, Form1.framesR(i + 140), Form1.framesG(i + 140), Form1.framesB(i + 140))
        OvalShape142.FillColor = Color.FromArgb(255, Form1.framesR(i + 141), Form1.framesG(i + 141), Form1.framesB(i + 141))
        OvalShape143.FillColor = Color.FromArgb(255, Form1.framesR(i + 142), Form1.framesG(i + 142), Form1.framesB(i + 142))
        OvalShape144.FillColor = Color.FromArgb(255, Form1.framesR(i + 143), Form1.framesG(i + 143), Form1.framesB(i + 143))
        OvalShape145.FillColor = Color.FromArgb(255, Form1.framesR(i + 144), Form1.framesG(i + 144), Form1.framesB(i + 144))
        OvalShape146.FillColor = Color.FromArgb(255, Form1.framesR(i + 145), Form1.framesG(i + 145), Form1.framesB(i + 145))
        OvalShape147.FillColor = Color.FromArgb(255, Form1.framesR(i + 146), Form1.framesG(i + 146), Form1.framesB(i + 146))
        OvalShape148.FillColor = Color.FromArgb(255, Form1.framesR(i + 147), Form1.framesG(i + 147), Form1.framesB(i + 147))
        OvalShape149.FillColor = Color.FromArgb(255, Form1.framesR(i + 148), Form1.framesG(i + 148), Form1.framesB(i + 148))
        OvalShape150.FillColor = Color.FromArgb(255, Form1.framesR(i + 149), Form1.framesG(i + 149), Form1.framesB(i + 149))
        OvalShape151.FillColor = Color.FromArgb(255, Form1.framesR(i + 150), Form1.framesG(i + 150), Form1.framesB(i + 150))
        OvalShape152.FillColor = Color.FromArgb(255, Form1.framesR(i + 151), Form1.framesG(i + 151), Form1.framesB(i + 151))
        OvalShape153.FillColor = Color.FromArgb(255, Form1.framesR(i + 152), Form1.framesG(i + 152), Form1.framesB(i + 152))
        OvalShape154.FillColor = Color.FromArgb(255, Form1.framesR(i + 153), Form1.framesG(i + 153), Form1.framesB(i + 153))
        OvalShape155.FillColor = Color.FromArgb(255, Form1.framesR(i + 154), Form1.framesG(i + 154), Form1.framesB(i + 154))
        OvalShape156.FillColor = Color.FromArgb(255, Form1.framesR(i + 155), Form1.framesG(i + 155), Form1.framesB(i + 155))
        OvalShape157.FillColor = Color.FromArgb(255, Form1.framesR(i + 156), Form1.framesG(i + 156), Form1.framesB(i + 156))
        OvalShape158.FillColor = Color.FromArgb(255, Form1.framesR(i + 157), Form1.framesG(i + 157), Form1.framesB(i + 157))
        OvalShape159.FillColor = Color.FromArgb(255, Form1.framesR(i + 158), Form1.framesG(i + 158), Form1.framesB(i + 158))
        OvalShape160.FillColor = Color.FromArgb(255, Form1.framesR(i + 159), Form1.framesG(i + 159), Form1.framesB(i + 159))
        OvalShape161.FillColor = Color.FromArgb(255, Form1.framesR(i + 160), Form1.framesG(i + 160), Form1.framesB(i + 160))
        OvalShape162.FillColor = Color.FromArgb(255, Form1.framesR(i + 161), Form1.framesG(i + 161), Form1.framesB(i + 161))
        OvalShape163.FillColor = Color.FromArgb(255, Form1.framesR(i + 162), Form1.framesG(i + 162), Form1.framesB(i + 162))
        OvalShape164.FillColor = Color.FromArgb(255, Form1.framesR(i + 163), Form1.framesG(i + 163), Form1.framesB(i + 163))
        OvalShape165.FillColor = Color.FromArgb(255, Form1.framesR(i + 164), Form1.framesG(i + 164), Form1.framesB(i + 164))
        OvalShape166.FillColor = Color.FromArgb(255, Form1.framesR(i + 165), Form1.framesG(i + 165), Form1.framesB(i + 165))
        OvalShape167.FillColor = Color.FromArgb(255, Form1.framesR(i + 166), Form1.framesG(i + 166), Form1.framesB(i + 166))
        OvalShape168.FillColor = Color.FromArgb(255, Form1.framesR(i + 167), Form1.framesG(i + 167), Form1.framesB(i + 167))
        OvalShape169.FillColor = Color.FromArgb(255, Form1.framesR(i + 168), Form1.framesG(i + 168), Form1.framesB(i + 168))
        OvalShape170.FillColor = Color.FromArgb(255, Form1.framesR(i + 169), Form1.framesG(i + 169), Form1.framesB(i + 169))
        OvalShape171.FillColor = Color.FromArgb(255, Form1.framesR(i + 170), Form1.framesG(i + 170), Form1.framesB(i + 170))
        OvalShape172.FillColor = Color.FromArgb(255, Form1.framesR(i + 171), Form1.framesG(i + 171), Form1.framesB(i + 171))
        OvalShape173.FillColor = Color.FromArgb(255, Form1.framesR(i + 172), Form1.framesG(i + 172), Form1.framesB(i + 172))
        OvalShape174.FillColor = Color.FromArgb(255, Form1.framesR(i + 173), Form1.framesG(i + 173), Form1.framesB(i + 173))
        OvalShape175.FillColor = Color.FromArgb(255, Form1.framesR(i + 174), Form1.framesG(i + 174), Form1.framesB(i + 174))
        OvalShape176.FillColor = Color.FromArgb(255, Form1.framesR(i + 175), Form1.framesG(i + 175), Form1.framesB(i + 175))
        OvalShape177.FillColor = Color.FromArgb(255, Form1.framesR(i + 176), Form1.framesG(i + 176), Form1.framesB(i + 176))
        OvalShape178.FillColor = Color.FromArgb(255, Form1.framesR(i + 177), Form1.framesG(i + 177), Form1.framesB(i + 177))
        OvalShape179.FillColor = Color.FromArgb(255, Form1.framesR(i + 178), Form1.framesG(i + 178), Form1.framesB(i + 178))
        OvalShape180.FillColor = Color.FromArgb(255, Form1.framesR(i + 179), Form1.framesG(i + 179), Form1.framesB(i + 179))
        OvalShape181.FillColor = Color.FromArgb(255, Form1.framesR(i + 180), Form1.framesG(i + 180), Form1.framesB(i + 180))
        OvalShape182.FillColor = Color.FromArgb(255, Form1.framesR(i + 181), Form1.framesG(i + 181), Form1.framesB(i + 181))
        OvalShape183.FillColor = Color.FromArgb(255, Form1.framesR(i + 182), Form1.framesG(i + 182), Form1.framesB(i + 182))
        OvalShape184.FillColor = Color.FromArgb(255, Form1.framesR(i + 183), Form1.framesG(i + 183), Form1.framesB(i + 183))
        OvalShape185.FillColor = Color.FromArgb(255, Form1.framesR(i + 184), Form1.framesG(i + 184), Form1.framesB(i + 184))
        OvalShape186.FillColor = Color.FromArgb(255, Form1.framesR(i + 185), Form1.framesG(i + 185), Form1.framesB(i + 185))
        OvalShape187.FillColor = Color.FromArgb(255, Form1.framesR(i + 186), Form1.framesG(i + 186), Form1.framesB(i + 186))
        OvalShape188.FillColor = Color.FromArgb(255, Form1.framesR(i + 187), Form1.framesG(i + 187), Form1.framesB(i + 187))
        OvalShape189.FillColor = Color.FromArgb(255, Form1.framesR(i + 188), Form1.framesG(i + 188), Form1.framesB(i + 188))
        OvalShape190.FillColor = Color.FromArgb(255, Form1.framesR(i + 189), Form1.framesG(i + 189), Form1.framesB(i + 189))
        OvalShape191.FillColor = Color.FromArgb(255, Form1.framesR(i + 190), Form1.framesG(i + 190), Form1.framesB(i + 190))
        OvalShape192.FillColor = Color.FromArgb(255, Form1.framesR(i + 191), Form1.framesG(i + 191), Form1.framesB(i + 191))
        OvalShape193.FillColor = Color.FromArgb(255, Form1.framesR(i + 192), Form1.framesG(i + 192), Form1.framesB(i + 192))
        OvalShape194.FillColor = Color.FromArgb(255, Form1.framesR(i + 193), Form1.framesG(i + 193), Form1.framesB(i + 193))
        OvalShape195.FillColor = Color.FromArgb(255, Form1.framesR(i + 194), Form1.framesG(i + 194), Form1.framesB(i + 194))
        OvalShape196.FillColor = Color.FromArgb(255, Form1.framesR(i + 195), Form1.framesG(i + 195), Form1.framesB(i + 195))
        OvalShape197.FillColor = Color.FromArgb(255, Form1.framesR(i + 196), Form1.framesG(i + 196), Form1.framesB(i + 196))
        OvalShape198.FillColor = Color.FromArgb(255, Form1.framesR(i + 197), Form1.framesG(i + 197), Form1.framesB(i + 197))
        OvalShape199.FillColor = Color.FromArgb(255, Form1.framesR(i + 198), Form1.framesG(i + 198), Form1.framesB(i + 198))
        OvalShape200.FillColor = Color.FromArgb(255, Form1.framesR(i + 199), Form1.framesG(i + 199), Form1.framesB(i + 199))


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Form1.CheckBox1.CheckState = CheckState.Unchecked) Then
            run(x * 200)
            x = x + 1
            If (x = Form1.NumericUpDown1.Value) Then
                x = 0
            End If
        Else
            If (sel = 1) Then
                moveup()
                setbottom(x)
                setdisplay()
                x = x + 1
                If (Form1.NumericUpDown1.Value * 8 = x) Then
                    x = 0
                End If
            ElseIf (sel = 2) Then
                movedown()
                settop(x)
                setdisplay()
                x = x + 1
                If (Form1.NumericUpDown1.Value * 8 = x) Then
                    x = 0
                End If
            ElseIf (sel = 3) Then
                moveleft()
                setright(x)
                setdisplay()
                x = x + 1
                If (Form1.NumericUpDown1.Value * 25 = x) Then
                    x = 0
                End If
            ElseIf (sel = 4) Then
                moveright()
                setleft(x)
                setdisplay()
                x = x + 1
                If (Form1.NumericUpDown1.Value * 25 = x) Then
                    x = 0
                End If
            End If
        End If

        
    End Sub
    
    Sub moveup()
        Dim y As Integer
        For y = 0 To 24
            co1(y) = co2(y)
            co2(y) = co3(y)
            co3(y) = co4(y)
            co4(y) = co5(y)
            co5(y) = co6(y)
            co6(y) = co7(y)
            co7(y) = co8(y)
        Next
    End Sub
    Sub movedown()
        Dim y As Integer
        For y = 0 To 24
            co8(y) = co7(y)
            co7(y) = co6(y)
            co6(y) = co5(y)
            co5(y) = co4(y)
            co4(y) = co3(y)
            co3(y) = co2(y)
            co2(y) = co1(y)
        Next
    End Sub

    Sub moveleft()
        Dim y As Integer
        For y = 0 To 23
            co1(y) = co1(y + 1)
            co2(y) = co2(y + 1)
            co3(y) = co3(y + 1)
            co4(y) = co4(y + 1)
            co5(y) = co5(y + 1)
            co6(y) = co6(y + 1)
            co7(y) = co7(y + 1)
            co8(y) = co8(y + 1)
        Next
    End Sub
    Sub moveright()
        Dim y As Integer
        For y = 0 To 23
            co1(24 - y) = co1(24 - y - 1)
            co2(24 - y) = co2(24 - y - 1)
            co3(24 - y) = co3(24 - y - 1)
            co4(24 - y) = co4(24 - y - 1)
            co5(24 - y) = co5(24 - y - 1)
            co6(24 - y) = co6(24 - y - 1)
            co7(24 - y) = co7(24 - y - 1)
            co8(24 - y) = co8(24 - y - 1)
        Next
    End Sub

    Sub setbottom(x As Long)
        Dim yy As Integer
        For yy = 0 To 24
            co8(yy) = Form1.f(x * 25 + yy)

        Next
    End Sub
    Sub settop(x As Long)
        Dim yy As Integer
        Dim h As Integer
        h = x Mod 8


        For yy = 0 To 24
            co1(yy) = Form1.f2(x * 25 + yy)

        Next

    End Sub
    Sub setright(x As Long)
        Dim j As Integer
        j = x Mod 25
        co1(24) = Form1.f3(x * 8 + 0)
        co2(24) = Form1.f3(x * 8 + 1)
        co3(24) = Form1.f3(x * 8 + 2)
        co4(24) = Form1.f3(x * 8 + 3)
        co5(24) = Form1.f3(x * 8 + 4)
        co6(24) = Form1.f3(x * 8 + 5)
        co7(24) = Form1.f3(x * 8 + 6)
        co8(24) = Form1.f3(x * 8 + 7)

    End Sub
    Sub setleft(x As Long)
        Dim j As Integer
        j = x Mod 25
        co1(0) = Form1.f4(x * 8 + 0)
        co2(0) = Form1.f4(x * 8 + 1)
        co3(0) = Form1.f4(x * 8 + 2)
        co4(0) = Form1.f4(x * 8 + 3)
        co5(0) = Form1.f4(x * 8 + 4)
        co6(0) = Form1.f4(x * 8 + 5)
        co7(0) = Form1.f4(x * 8 + 6)
        co8(0) = Form1.f4(x * 8 + 7)

    End Sub

    Sub setdisplay()
        OvalShape1.FillColor = co1(0)
        OvalShape16.FillColor = co1(1)
        OvalShape17.FillColor = co1(2)
        OvalShape32.FillColor = co1(3)
        OvalShape33.FillColor = co1(4)
        OvalShape48.FillColor = co1(5)
        OvalShape49.FillColor = co1(6)
        OvalShape64.FillColor = co1(7)
        OvalShape65.FillColor = co1(8)
        OvalShape80.FillColor = co1(9)
        OvalShape81.FillColor = co1(10)
        OvalShape96.FillColor = co1(11)
        OvalShape97.FillColor = co1(12)
        OvalShape112.FillColor = co1(13)
        OvalShape113.FillColor = co1(14)
        OvalShape128.FillColor = co1(15)
        OvalShape129.FillColor = co1(16)
        OvalShape144.FillColor = co1(17)
        OvalShape145.FillColor = co1(18)
        OvalShape160.FillColor = co1(19)
        OvalShape161.FillColor = co1(20)
        OvalShape176.FillColor = co1(21)
        OvalShape177.FillColor = co1(22)
        OvalShape192.FillColor = co1(23)
        OvalShape193.FillColor = co1(24)
        OvalShape2.FillColor = co2(0)
        OvalShape15.FillColor = co2(1)
        OvalShape18.FillColor = co2(2)
        OvalShape31.FillColor = co2(3)
        OvalShape34.FillColor = co2(4)
        OvalShape47.FillColor = co2(5)
        OvalShape50.FillColor = co2(6)
        OvalShape63.FillColor = co2(7)
        OvalShape66.FillColor = co2(8)
        OvalShape79.FillColor = co2(9)
        OvalShape82.FillColor = co2(10)
        OvalShape95.FillColor = co2(11)
        OvalShape98.FillColor = co2(12)
        OvalShape111.FillColor = co2(13)
        OvalShape114.FillColor = co2(14)
        OvalShape127.FillColor = co2(15)
        OvalShape130.FillColor = co2(16)
        OvalShape143.FillColor = co2(17)
        OvalShape146.FillColor = co2(18)
        OvalShape159.FillColor = co2(19)
        OvalShape162.FillColor = co2(20)
        OvalShape175.FillColor = co2(21)
        OvalShape178.FillColor = co2(22)
        OvalShape191.FillColor = co2(23)
        OvalShape194.FillColor = co2(24)
        OvalShape3.FillColor = co3(0)
        OvalShape14.FillColor = co3(1)
        OvalShape19.FillColor = co3(2)
        OvalShape30.FillColor = co3(3)
        OvalShape35.FillColor = co3(4)
        OvalShape46.FillColor = co3(5)
        OvalShape51.FillColor = co3(6)
        OvalShape62.FillColor = co3(7)
        OvalShape67.FillColor = co3(8)
        OvalShape78.FillColor = co3(9)
        OvalShape83.FillColor = co3(10)
        OvalShape94.FillColor = co3(11)
        OvalShape99.FillColor = co3(12)
        OvalShape110.FillColor = co3(13)
        OvalShape115.FillColor = co3(14)
        OvalShape126.FillColor = co3(15)
        OvalShape131.FillColor = co3(16)
        OvalShape142.FillColor = co3(17)
        OvalShape147.FillColor = co3(18)
        OvalShape158.FillColor = co3(19)
        OvalShape163.FillColor = co3(20)
        OvalShape174.FillColor = co3(21)
        OvalShape179.FillColor = co3(22)
        OvalShape190.FillColor = co3(23)
        OvalShape195.FillColor = co3(24)
        OvalShape4.FillColor = co4(0)
        OvalShape13.FillColor = co4(1)
        OvalShape20.FillColor = co4(2)
        OvalShape29.FillColor = co4(3)
        OvalShape36.FillColor = co4(4)
        OvalShape45.FillColor = co4(5)
        OvalShape52.FillColor = co4(6)
        OvalShape61.FillColor = co4(7)
        OvalShape68.FillColor = co4(8)
        OvalShape77.FillColor = co4(9)
        OvalShape84.FillColor = co4(10)
        OvalShape93.FillColor = co4(11)
        OvalShape100.FillColor = co4(12)
        OvalShape109.FillColor = co4(13)
        OvalShape116.FillColor = co4(14)
        OvalShape125.FillColor = co4(15)
        OvalShape132.FillColor = co4(16)
        OvalShape141.FillColor = co4(17)
        OvalShape148.FillColor = co4(18)
        OvalShape157.FillColor = co4(19)
        OvalShape164.FillColor = co4(20)
        OvalShape173.FillColor = co4(21)
        OvalShape180.FillColor = co4(22)
        OvalShape189.FillColor = co4(23)
        OvalShape196.FillColor = co4(24)
        OvalShape5.FillColor = co5(0)
        OvalShape12.FillColor = co5(1)
        OvalShape21.FillColor = co5(2)
        OvalShape28.FillColor = co5(3)
        OvalShape37.FillColor = co5(4)
        OvalShape44.FillColor = co5(5)
        OvalShape53.FillColor = co5(6)
        OvalShape60.FillColor = co5(7)
        OvalShape69.FillColor = co5(8)
        OvalShape76.FillColor = co5(9)
        OvalShape85.FillColor = co5(10)
        OvalShape92.FillColor = co5(11)
        OvalShape101.FillColor = co5(12)
        OvalShape108.FillColor = co5(13)
        OvalShape117.FillColor = co5(14)
        OvalShape124.FillColor = co5(15)
        OvalShape133.FillColor = co5(16)
        OvalShape140.FillColor = co5(17)
        OvalShape149.FillColor = co5(18)
        OvalShape156.FillColor = co5(19)
        OvalShape165.FillColor = co5(20)
        OvalShape172.FillColor = co5(21)
        OvalShape181.FillColor = co5(22)
        OvalShape188.FillColor = co5(23)
        OvalShape197.FillColor = co5(24)
        OvalShape6.FillColor = co6(0)
        OvalShape11.FillColor = co6(1)
        OvalShape22.FillColor = co6(2)
        OvalShape27.FillColor = co6(3)
        OvalShape38.FillColor = co6(4)
        OvalShape43.FillColor = co6(5)
        OvalShape54.FillColor = co6(6)
        OvalShape59.FillColor = co6(7)
        OvalShape70.FillColor = co6(8)
        OvalShape75.FillColor = co6(9)
        OvalShape86.FillColor = co6(10)
        OvalShape91.FillColor = co6(11)
        OvalShape102.FillColor = co6(12)
        OvalShape107.FillColor = co6(13)
        OvalShape118.FillColor = co6(14)
        OvalShape123.FillColor = co6(15)
        OvalShape134.FillColor = co6(16)
        OvalShape139.FillColor = co6(17)
        OvalShape150.FillColor = co6(18)
        OvalShape155.FillColor = co6(19)
        OvalShape166.FillColor = co6(20)
        OvalShape171.FillColor = co6(21)
        OvalShape182.FillColor = co6(22)
        OvalShape187.FillColor = co6(23)
        OvalShape198.FillColor = co6(24)
        OvalShape7.FillColor = co7(0)
        OvalShape10.FillColor = co7(1)
        OvalShape23.FillColor = co7(2)
        OvalShape26.FillColor = co7(3)
        OvalShape39.FillColor = co7(4)
        OvalShape42.FillColor = co7(5)
        OvalShape55.FillColor = co7(6)
        OvalShape58.FillColor = co7(7)
        OvalShape71.FillColor = co7(8)
        OvalShape74.FillColor = co7(9)
        OvalShape87.FillColor = co7(10)
        OvalShape90.FillColor = co7(11)
        OvalShape103.FillColor = co7(12)
        OvalShape106.FillColor = co7(13)
        OvalShape119.FillColor = co7(14)
        OvalShape122.FillColor = co7(15)
        OvalShape135.FillColor = co7(16)
        OvalShape138.FillColor = co7(17)
        OvalShape151.FillColor = co7(18)
        OvalShape154.FillColor = co7(19)
        OvalShape167.FillColor = co7(20)
        OvalShape170.FillColor = co7(21)
        OvalShape183.FillColor = co7(22)
        OvalShape186.FillColor = co7(23)
        OvalShape199.FillColor = co7(24)
        OvalShape8.FillColor = co8(0)
        OvalShape9.FillColor = co8(1)
        OvalShape24.FillColor = co8(2)
        OvalShape25.FillColor = co8(3)
        OvalShape40.FillColor = co8(4)
        OvalShape41.FillColor = co8(5)
        OvalShape56.FillColor = co8(6)
        OvalShape57.FillColor = co8(7)
        OvalShape72.FillColor = co8(8)
        OvalShape73.FillColor = co8(9)
        OvalShape88.FillColor = co8(10)
        OvalShape89.FillColor = co8(11)
        OvalShape104.FillColor = co8(12)
        OvalShape105.FillColor = co8(13)
        OvalShape120.FillColor = co8(14)
        OvalShape121.FillColor = co8(15)
        OvalShape136.FillColor = co8(16)
        OvalShape137.FillColor = co8(17)
        OvalShape152.FillColor = co8(18)
        OvalShape153.FillColor = co8(19)
        OvalShape168.FillColor = co8(20)
        OvalShape169.FillColor = co8(21)
        OvalShape184.FillColor = co8(22)
        OvalShape185.FillColor = co8(23)
        OvalShape200.FillColor = co8(24)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
        sel = 1
        Button1.BackColor = Color.Red
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        sel = 2
        Button1.BackColor = Color.White
        Button2.BackColor = Color.Red
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        sel = 3
        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.Red
        Button4.BackColor = Color.White
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Timer1.Stop()
        sel = 4
        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.Red
    End Sub

End Class