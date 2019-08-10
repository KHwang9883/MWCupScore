Public Class Form1
    Dim x1, x2, s1, s2, c1, c2, t1, t2, y1, y2, f1, f2, k1, k2 As String
    Dim gq, lun, xs, xsm, pw1, pw2, lou1, lou2 As String
    Dim a, b, c As String
    Dim z1, z2, z3 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x1 = Xinshang1.Text
        x2 = Xinshang2.Text
        s1 = Sheji1.Text
        s2 = Sheji2.Text
        c1 = Chuangxin1.Text
        c2 = Chuangxin2.Text
        t1 = Tiaozhan1.Text
        t2 = Tiaozhan2.Text
        y1 = Yule1.Text
        y2 = Yule2.Text
        f1 = Fujia1.Text
        f2 = Fujia2.Text
        k1 = Koufen1.Text
        k2 = Koufen2.Text
        z1 = Val(x1) + Val(s1) + Val(c1) + Val(t1) + Val(y1) + Val(f1) + Val(k1)
        z2 = Val(x2) + Val(s2) + Val(c2) + Val(t2) + Val(y2) + Val(f2) + Val(k2)
        z3 = (z1 + z2) / 2
        a = CStr(z1)
        b = CStr(z2)
        c = CStr(z3)
        gq = Guanqia.Text
        lun = Lunci.Text
        xs = Xuanshou.Text
        xsm = Xuanshouma.Text
        pw1 = Pingwei1.Text
        pw2 = Pingwei2.Text
        lou1 = Louceng1.Text
        lou2 = Louceng2.Text
        If RadioButton2.Checked Then
            Jiefen.Text = "比赛：" + lun + vbCrLf + "参赛关卡：" + gq + vbCrLf + "参赛选手：" + xs + vbCrLf + vbCrLf + "评委1 @" + pw1 + " 评分：（" + lou1 + "楼）" + vbCrLf + "A.设计分" + vbCrLf + "欣赏性：" + x1 + "/10" + vbCrLf + "设计水平：" + s1 + "/30" + vbCrLf + "创新性：" + c1 + "/15" + vbCrLf + "B.游戏性分" + vbCrLf + "挑战性：" + t1 + "/15" + vbCrLf + "娱乐性：" + y1 + "/30" + vbCrLf + "C.加分与扣分" + vbCrLf + "加分：" + f1 + "/5" + vbCrLf + "扣分：" + k1 + vbCrLf + "总分：" + a + "/105" + vbCrLf + vbCrLf + "评委2 @" + pw2 + " 评分：（" + lou2 + "楼）" + vbCrLf + "A.设计分" + vbCrLf + "欣赏性：" + x2 + "/10" + vbCrLf + "设计水平：" + s2 + "/30" + vbCrLf + "创新性：" + c2 + "/15" + vbCrLf + "B.游戏性分" + vbCrLf + "挑战性：" + t2 + "/15" + vbCrLf + "娱乐性：" + y2 + "/30" + vbCrLf + "C.加分与扣分" + vbCrLf + "加分：" + f2 + "/5" + vbCrLf + "扣分：" + k2 + vbCrLf + "总分：" + b + "/105" + vbCrLf + vbCrLf + xsm + "选手 " + lun + "关卡最终得分：（" + a + "+" + b + "）/2=" + c
        ElseIf RadioButton3.Checked Then
            Jiefen.Text = "比赛：" + lun + vbCrLf + "参赛关卡：" + gq + vbCrLf + "参赛选手：" + xs + vbCrLf + vbCrLf + "评委1 @" + pw1 + " 评分：（" + lou1 + "楼）" + vbCrLf + "A.设计分" + vbCrLf + "欣赏性：" + x1 + "/10" + vbCrLf + "设计水平：" + s1 + "/30" + vbCrLf + "创新性：" + c1 + "/15" + vbCrLf + "B.游戏性分" + vbCrLf + "挑战性：" + t1 + "/15" + vbCrLf + "娱乐性：" + y1 + "/30" + vbCrLf + "C.加分与扣分" + vbCrLf + "加分：" + f1 + "/8" + vbCrLf + "扣分：" + k1 + vbCrLf + "总分：" + a + "/108" + vbCrLf + vbCrLf + "评委2 @" + pw2 + " 评分：（" + lou2 + "楼）" + vbCrLf + "A.设计分" + vbCrLf + "欣赏性：" + x2 + "/10" + vbCrLf + "设计水平：" + s2 + "/30" + vbCrLf + "创新性：" + c2 + "/15" + vbCrLf + "B.游戏性分" + vbCrLf + "挑战性：" + t2 + "/15" + vbCrLf + "娱乐性：" + y2 + "/30" + vbCrLf + "C.加分与扣分" + vbCrLf + "加分：" + f2 + "/8" + vbCrLf + "扣分：" + k2 + vbCrLf + "总分：" + b + "/108" + vbCrLf + vbCrLf + xsm + "选手 " + lun + "关卡最终得分：（" + a + "+" + b + "）/2=" + c
        ElseIf RadioButton4.Checked Then
            Jiefen.Text = "比赛：" + lun + vbCrLf + "参赛关卡：" + gq + vbCrLf + "参赛选手：" + xs + vbCrLf + vbCrLf + "评委1 @" + pw1 + " 评分：（" + lou1 + "楼）" + vbCrLf + "A.设计分" + vbCrLf + "欣赏性：" + x1 + "/10" + vbCrLf + "设计水平：" + s1 + "/30" + vbCrLf + "创新性：" + c1 + "/15" + vbCrLf + "B.游戏性分" + vbCrLf + "挑战性：" + t1 + "/15" + vbCrLf + "娱乐性：" + y1 + "/30" + vbCrLf + "C.加分与扣分" + vbCrLf + "加分：" + f1 + "/10" + vbCrLf + "扣分：" + k1 + vbCrLf + "总分：" + a + "/110" + vbCrLf + vbCrLf + "评委2 @" + pw2 + " 评分：（" + lou2 + "楼）" + vbCrLf + "A.设计分" + vbCrLf + "欣赏性：" + x2 + "/10" + vbCrLf + "设计水平：" + s2 + "/30" + vbCrLf + "创新性：" + c2 + "/15" + vbCrLf + "B.游戏性分" + vbCrLf + "挑战性：" + t2 + "/15" + vbCrLf + "娱乐性：" + y2 + "/30" + vbCrLf + "C.加分与扣分" + vbCrLf + "加分：" + f2 + "/10" + vbCrLf + "扣分：" + k2 + vbCrLf + "总分：" + b + "/110" + vbCrLf + vbCrLf + xsm + "选手 " + lun + "关卡最终得分：（" + a + "+" + b + "）/2=" + c
        Else
            Jiefen.Text = "比赛：" + lun + vbCrLf + "参赛关卡：" + gq + vbCrLf + "参赛选手：" + xs + vbCrLf + vbCrLf + "评委1 @" + pw1 + " 评分：（" + lou1 + "楼）" + vbCrLf + "A.设计分" + vbCrLf + "欣赏性：" + x1 + "/10" + vbCrLf + "设计水平：" + s1 + "/30" + vbCrLf + "创新性：" + c1 + "/15" + vbCrLf + "B.游戏性分" + vbCrLf + "挑战性：" + t1 + "/15" + vbCrLf + "娱乐性：" + y1 + "/30" + vbCrLf + "C.加分与扣分" + vbCrLf + "扣分：" + k1 + vbCrLf + "总分：" + a + "/100" + vbCrLf + vbCrLf + "评委2 @" + pw2 + " 评分：（" + lou2 + "楼）" + vbCrLf + "A.设计分" + vbCrLf + "欣赏性：" + x2 + "/10" + vbCrLf + "设计水平：" + s2 + "/30" + vbCrLf + "创新性：" + c2 + "/15" + vbCrLf + "B.游戏性分" + vbCrLf + "挑战性：" + t2 + "/15" + vbCrLf + "娱乐性：" + y2 + "/30" + vbCrLf + "C.加分与扣分" + vbCrLf + "扣分：" + k2 + vbCrLf + "总分：" + b + "/100" + vbCrLf + vbCrLf + xsm + "选手 " + lun + "关卡最终得分：（" + a + "+" + b + "）/2=" + c

        End If
    End Sub
End Class
