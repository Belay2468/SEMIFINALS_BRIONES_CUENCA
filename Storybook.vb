Imports System.Media

Public Class Storybook

    Dim Info As String
    Dim Player As New SoundPlayer
    Dim Muted As Boolean = False

    Private Sub pb1sypno_Click(sender As Object, e As EventArgs) Handles pb1sypno.Click

        Info = " In the magical depths of the ocean, an enchanting kingdom thrived, ruled by King Triton. Among his seven daughters, one mermaid, in particular, was different. Her name was Ariel, a spirited and adventurous young mermaid with an insatiable curiosity about the human world."
        rtbsypno.Text = Info
        pb1sypno.Image = My.Resources.Underwater
        pb1sypno.SizeMode = PictureBoxSizeMode.StretchImage
        Player = New SoundPlayer(My.Resources.Scene_1_narrator_1)
        Player.Play()

    End Sub

    Private Sub rdchap1_1sypno_CheckedChanged(sender As Object, e As EventArgs) Handles rdchap1_1sypno.CheckedChanged
        Info = "Ariel twirls around, clutching various trinkets and treasures she has collected from shipwrecks.Ariel's heart yearned for the surface, where humans danced upon ships, and the wonders of their world seemed endless. The call of the unknown tugged at her, drawing her closer to her dreams. As Ariel sings, her voice carries through the ocean, captivating her friend Flounder, who swims nearby. Unbeknownst to Ariel, her longing for the surface would lead her on a remarkable journey, where she would discover the true meaning of love, sacrifice, and the power of her own voice."
        rtbsypno.Text = Info
        pb1sypno.Image = My.Resources.Scene_1_pic_1
        pb1sypno.SizeMode = PictureBoxSizeMode.StretchImage
        Player = New SoundPlayer(My.Resources.Scene_1_descrpt_1)
        Player.Play()



    End Sub

    Private Sub rdchap1_2sypno_CheckedChanged(sender As Object, e As EventArgs) Handles rdchap1_2sypno.CheckedChanged

        Info = " A sea witch, who is feared by mermen due to her strange abilities and reputation as a cunning con artist, dwelt in the shadowy depths of the ocean. She gained her power by seducing her victims into signing a lethal contract that put their lives in danger. The moment the eels barged into Ursula's lair, the witch panicked and hid the letter she was clutching. Flotsam suddenly went behind the witch and grabs the paper she’s holding and started reading it."
        rtbsypno.Text = Info
        pb1sypno.Image = My.Resources.Scene_1_pic_2
        pb1sypno.SizeMode = PictureBoxSizeMode.StretchImage
        Player = New SoundPlayer(My.Resources.Scene_1_descrpt_2__1_)
        Player.Play()


    End Sub

    Private Sub rdchap1_3sypno_CheckedChanged(sender As Object, e As EventArgs) Handles rdchap1_3sypno.CheckedChanged
        Info = "Jetsam giggles while they both tease Ursula who’s starting to get pissed because of the two annoying eels. The two wistfully left the place laughing while bumping onto each other as Ursula hid the letter and sat on her throne."
        rtbsypno.Text = Info
        pb1sypno.Image = My.Resources.Scene_1_pic_3
        pb1sypno.SizeMode = PictureBoxSizeMode.StretchImage
        Player = New SoundPlayer(My.Resources.Scene_1_descrpt_3)
        Player.Play()

    End Sub


    Private Sub rdchap1_1chap1_CheckedChanged(sender As Object, e As EventArgs) Handles rdchap1_1chap1.CheckedChanged
        Info = "On a stormy night, Prince Eric's ship is caught in a violent tempest. The waves crash mercilessly, threatening to engulf the vessel. Amidst the chaos, Ariel, emerges from the water, swimming with desperate determination. Ariel spots Prince Eric, struggling to stay afloat amidst the wreckage. Without hesitation, she dives into the treacherous sea, swimming towards him with incredible speed."
        rtbchap1.Text = Info
        pb2chap1.Image = My.Resources.Scene_2_pic_1
        pb2chap1.SizeMode = PictureBoxSizeMode.StretchImage
        Player = New SoundPlayer(My.Resources.Scene_2_descrpt_1)
        Player.Play()
    End Sub

    Private Sub rdchap1_2chap1_CheckedChanged(sender As Object, e As EventArgs) Handles rdchap1_2chap1.CheckedChanged
        Info = "Ariel reaches Prince Eric just as he begins to lose consciousness. With all her strength, she pulls him to safety and onto a piece of debris, shielding him from the raging waters. As the rain subsides, a moment of calm settles upon the scene. Ariel gazes at Prince Eric, her heart yearning to express the depth of her feelings. With an overwhelming surge of emotion, she begins to softly sing, her voice filled with longing and vulnerability."
        rtbchap1.Text = Info
        pb2chap1.Image = My.Resources.Scene_2_pic_2
        Player = New SoundPlayer(My.Resources.Scene_2_descrpt_2)
        pb2chap1.SizeMode = PictureBoxSizeMode.StretchImage
        Player.Play()
    End Sub

    Private Sub rdchap1_3chap1_CheckedChanged(sender As Object, e As EventArgs) Handles rdchap1_3chap1.CheckedChanged
        Info = "Prince Eric listens, captivated by the beauty and emotion in Ariel's voice. Their connection deepens, and a profound understanding passes between them. Ariel immediately hid behind a huge rock as the people helped the prince, she let out a deep sigh while thinking that she is inlove with him and want to be with him as soon as possible."
        rtbchap1.Text = Info
        pb2chap1.Image = My.Resources.scene_2_pic_3

        Player = New SoundPlayer(My.Resources.Scene_2_descrpt_3)
        pb2chap1.SizeMode = PictureBoxSizeMode.StretchImage
        Player.Play()
    End Sub

    Private Sub rdchap1_1chap2_CheckedChanged(sender As Object, e As EventArgs) Handles rdchap1_1chap2.CheckedChanged
        Info = "Underwater, Ariel and Flounder swim together, playfully darting through the colorful coral reefs. They share a smile and continue swimming through the underwater wonderland, their excitement and curiosity bubbling with each passing moment "
        rtbchap2.Text = Info
        pb3chap2.Image = My.Resources.Scene_3_pic_2
        pb3chap2.SizeMode = PictureBoxSizeMode.StretchImage
        Player = New SoundPlayer(My.Resources.scene_3descrpt1)
        Player.Play()
    End Sub

    Private Sub rdchap1_1chap4_CheckedChanged(sender As Object, e As EventArgs) Handles rdchap1_1chap4.CheckedChanged
        Info = "Ariel swims near a secluded and mysterious cave, where Ursula, the sea witch, resides. Ursula emerges from the shadows, her presence commanding and ominous. Ursula begins to sing, her voice taking on a mesmerizing and enchanting quality"
        rtbchap4.Text = Info
        pb5chap4.Image = My.Resources.Scene_4_pic_1
        Player = New SoundPlayer(My.Resources.Scene_4_descrpt_1)
        pb5chap4.SizeMode = PictureBoxSizeMode.StretchImage
        Player.Play()
    End Sub

    Private Sub rdchap1_2chap4_CheckedChanged(sender As Object, e As EventArgs) Handles rdchap1_2chap4.CheckedChanged
        Info = "Ariel listens intently, captivated by Ursula's song. Ariel's expression reveals a mixture of fascination and trepidation. Ariel started harmonizing as Ursula take her voice while grinning at the little mermaid who now doesn’t have the ability to sing nor talk."
        rtbchap4.Text = Info
        pb5chap4.Image = My.Resources.Scene_4_pic_2
        Player = New SoundPlayer(My.Resources.Scene_4_descrpt_2)
        pb5chap4.SizeMode = PictureBoxSizeMode.StretchImage
        Player.Play()
    End Sub

    Private Sub rdchap1_3chap4_CheckedChanged(sender As Object, e As EventArgs) Handles rdchap1_3chap4.CheckedChanged
        Info = "As Ursula clutches the seashell containing the enchanted song she handed the paper to Arial waiting for the little mermaid to sign the agreement she then laughed loudly as Ursula disappears into the shadows, leaving Ariel alone with her newfound determination and the weight of her decision"
        rtbchap4.Text = Info
        pb5chap4.Image = My.Resources.Scene_4_pic_3
        Player = New SoundPlayer(My.Resources.Scene_4_descrpt_3)
        pb5chap4.SizeMode = PictureBoxSizeMode.StretchImage
        Player.Play()
    End Sub

    Private Sub btnplaysypno_Click(sender As Object, e As EventArgs) Handles btnplaysypno.Click
        Player = New SoundPlayer()
        Player.Play()
    End Sub
    Private Sub btnstopsypno_Click(sender As Object, e As EventArgs) Handles btnstopsypno.Click
        Player.Stop()
    End Sub
    Private Sub btnplaychap1_Click(sender As Object, e As EventArgs) Handles btnplaychap1.Click

    End Sub
    Private Sub btnstopchap1_Click(sender As Object, e As EventArgs) Handles btnstopchap1.Click
        Player.Stop()
    End Sub

    Private Sub btnplaychap2_Click(sender As Object, e As EventArgs) Handles btnplaychap2.Click
        Player = New SoundPlayer()
        Player.Play()
    End Sub

    Private Sub btnstopchap2_Click(sender As Object, e As EventArgs) Handles btnstopchap2.Click
        Player.Stop()
    End Sub

    Private Sub btnplaychap3_Click(sender As Object, e As EventArgs) Handles btnplaychap3.Click
        Player = New SoundPlayer()
        Player.Play()
    End Sub

    Private Sub btnstopchap3_Click(sender As Object, e As EventArgs) Handles btnstopchap3.Click
        Player.Stop()
    End Sub

    Private Sub btnplaychap4_Click(sender As Object, e As EventArgs) Handles btnplaychap4.Click
        Player = New SoundPlayer()
        Player.Play()
    End Sub

    Private Sub btnstopchap4_Click(sender As Object, e As EventArgs) Handles btnstopchap4.Click
        Player.Stop()
    End Sub
End Class
