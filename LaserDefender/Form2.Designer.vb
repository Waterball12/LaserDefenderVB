<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.PlayerScorePanel = New System.Windows.Forms.Panel()
        Me.LifeCounter = New System.Windows.Forms.Label()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.LevelText = New System.Windows.Forms.Label()
        Me.DistanceEarthCounter = New System.Windows.Forms.Label()
        Me.DistanceFromEartText = New System.Windows.Forms.Label()
        Me.ScoreText = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlienPlane = New System.Windows.Forms.PictureBox()
        Me.EarthImage = New System.Windows.Forms.PictureBox()
        Me.LifeImage = New System.Windows.Forms.PictureBox()
        Me.EnemyPosition7 = New System.Windows.Forms.PictureBox()
        Me.EnemyPosition6 = New System.Windows.Forms.PictureBox()
        Me.EnemyPosition5 = New System.Windows.Forms.PictureBox()
        Me.EnemyPosition3 = New System.Windows.Forms.PictureBox()
        Me.EnemyPosition2 = New System.Windows.Forms.PictureBox()
        Me.EnemyPosition1 = New System.Windows.Forms.PictureBox()
        Me.SpaceShipPosition = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlayerScorePanel.SuspendLayout()
        CType(Me.AlienPlane, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EarthImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LifeImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyPosition7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyPosition6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyPosition5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyPosition3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyPosition2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyPosition1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceShipPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ScoreLabel.Location = New System.Drawing.Point(632, 0)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(29, 31)
        Me.ScoreLabel.TabIndex = 0
        Me.ScoreLabel.Text = "0"
        '
        'PlayerScorePanel
        '
        Me.PlayerScorePanel.Controls.Add(Me.LifeCounter)
        Me.PlayerScorePanel.Controls.Add(Me.Label2)
        Me.PlayerScorePanel.Controls.Add(Me.LifeImage)
        Me.PlayerScorePanel.Controls.Add(Me.LevelLabel)
        Me.PlayerScorePanel.Controls.Add(Me.LevelText)
        Me.PlayerScorePanel.Controls.Add(Me.DistanceEarthCounter)
        Me.PlayerScorePanel.Controls.Add(Me.DistanceFromEartText)
        Me.PlayerScorePanel.Controls.Add(Me.ScoreText)
        Me.PlayerScorePanel.Controls.Add(Me.Label1)
        Me.PlayerScorePanel.Controls.Add(Me.ScoreLabel)
        Me.PlayerScorePanel.Location = New System.Drawing.Point(0, 1)
        Me.PlayerScorePanel.Name = "PlayerScorePanel"
        Me.PlayerScorePanel.Size = New System.Drawing.Size(743, 35)
        Me.PlayerScorePanel.TabIndex = 8
        '
        'LifeCounter
        '
        Me.LifeCounter.AutoSize = True
        Me.LifeCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LifeCounter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LifeCounter.Location = New System.Drawing.Point(181, 0)
        Me.LifeCounter.Name = "LifeCounter"
        Me.LifeCounter.Size = New System.Drawing.Size(29, 31)
        Me.LifeCounter.TabIndex = 11
        Me.LifeCounter.Text = "3"
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LevelLabel.Location = New System.Drawing.Point(83, 0)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(29, 31)
        Me.LevelLabel.TabIndex = 6
        Me.LevelLabel.Text = "1"
        '
        'LevelText
        '
        Me.LevelText.AutoSize = True
        Me.LevelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LevelText.Location = New System.Drawing.Point(12, 6)
        Me.LevelText.Name = "LevelText"
        Me.LevelText.Size = New System.Drawing.Size(65, 25)
        Me.LevelText.TabIndex = 5
        Me.LevelText.Text = "Level:"
        '
        'DistanceEarthCounter
        '
        Me.DistanceEarthCounter.AutoSize = True
        Me.DistanceEarthCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistanceEarthCounter.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.DistanceEarthCounter.Location = New System.Drawing.Point(437, 0)
        Me.DistanceEarthCounter.Name = "DistanceEarthCounter"
        Me.DistanceEarthCounter.Size = New System.Drawing.Size(29, 31)
        Me.DistanceEarthCounter.TabIndex = 4
        Me.DistanceEarthCounter.Text = "0"
        '
        'DistanceFromEartText
        '
        Me.DistanceFromEartText.AutoSize = True
        Me.DistanceFromEartText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistanceFromEartText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DistanceFromEartText.Location = New System.Drawing.Point(216, 6)
        Me.DistanceFromEartText.Name = "DistanceFromEartText"
        Me.DistanceFromEartText.Size = New System.Drawing.Size(188, 25)
        Me.DistanceFromEartText.TabIndex = 3
        Me.DistanceFromEartText.Text = "Distance from Earth:"
        '
        'ScoreText
        '
        Me.ScoreText.AutoSize = True
        Me.ScoreText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreText.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ScoreText.Location = New System.Drawing.Point(536, 6)
        Me.ScoreText.Name = "ScoreText"
        Me.ScoreText.Size = New System.Drawing.Size(70, 25)
        Me.ScoreText.TabIndex = 2
        Me.ScoreText.Text = "Score:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(569, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'AlienPlane
        '
        Me.AlienPlane.Image = CType(resources.GetObject("AlienPlane.Image"), System.Drawing.Image)
        Me.AlienPlane.Location = New System.Drawing.Point(348, 42)
        Me.AlienPlane.Name = "AlienPlane"
        Me.AlienPlane.Size = New System.Drawing.Size(33, 30)
        Me.AlienPlane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlienPlane.TabIndex = 10
        Me.AlienPlane.TabStop = False
        '
        'EarthImage
        '
        Me.EarthImage.Image = CType(resources.GetObject("EarthImage.Image"), System.Drawing.Image)
        Me.EarthImage.Location = New System.Drawing.Point(326, 484)
        Me.EarthImage.Name = "EarthImage"
        Me.EarthImage.Size = New System.Drawing.Size(78, 55)
        Me.EarthImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EarthImage.TabIndex = 9
        Me.EarthImage.TabStop = False
        '
        'LifeImage
        '
        Me.LifeImage.Image = CType(resources.GetObject("LifeImage.Image"), System.Drawing.Image)
        Me.LifeImage.Location = New System.Drawing.Point(127, 5)
        Me.LifeImage.Name = "LifeImage"
        Me.LifeImage.Size = New System.Drawing.Size(36, 25)
        Me.LifeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LifeImage.TabIndex = 11
        Me.LifeImage.TabStop = False
        '
        'EnemyPosition7
        '
        Me.EnemyPosition7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EnemyPosition7.Location = New System.Drawing.Point(551, 162)
        Me.EnemyPosition7.Name = "EnemyPosition7"
        Me.EnemyPosition7.Size = New System.Drawing.Size(55, 52)
        Me.EnemyPosition7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyPosition7.TabIndex = 7
        Me.EnemyPosition7.TabStop = False
        '
        'EnemyPosition6
        '
        Me.EnemyPosition6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EnemyPosition6.Location = New System.Drawing.Point(469, 76)
        Me.EnemyPosition6.Name = "EnemyPosition6"
        Me.EnemyPosition6.Size = New System.Drawing.Size(55, 52)
        Me.EnemyPosition6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyPosition6.TabIndex = 6
        Me.EnemyPosition6.TabStop = False
        '
        'EnemyPosition5
        '
        Me.EnemyPosition5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EnemyPosition5.Location = New System.Drawing.Point(364, 162)
        Me.EnemyPosition5.Name = "EnemyPosition5"
        Me.EnemyPosition5.Size = New System.Drawing.Size(55, 52)
        Me.EnemyPosition5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyPosition5.TabIndex = 5
        Me.EnemyPosition5.TabStop = False
        '
        'EnemyPosition3
        '
        Me.EnemyPosition3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EnemyPosition3.Location = New System.Drawing.Point(276, 76)
        Me.EnemyPosition3.Name = "EnemyPosition3"
        Me.EnemyPosition3.Size = New System.Drawing.Size(55, 52)
        Me.EnemyPosition3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyPosition3.TabIndex = 4
        Me.EnemyPosition3.TabStop = False
        '
        'EnemyPosition2
        '
        Me.EnemyPosition2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EnemyPosition2.Location = New System.Drawing.Point(173, 162)
        Me.EnemyPosition2.Name = "EnemyPosition2"
        Me.EnemyPosition2.Size = New System.Drawing.Size(55, 52)
        Me.EnemyPosition2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyPosition2.TabIndex = 3
        Me.EnemyPosition2.TabStop = False
        '
        'EnemyPosition1
        '
        Me.EnemyPosition1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.EnemyPosition1.Location = New System.Drawing.Point(80, 76)
        Me.EnemyPosition1.Name = "EnemyPosition1"
        Me.EnemyPosition1.Size = New System.Drawing.Size(55, 52)
        Me.EnemyPosition1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyPosition1.TabIndex = 2
        Me.EnemyPosition1.TabStop = False
        '
        'SpaceShipPosition
        '
        Me.SpaceShipPosition.Location = New System.Drawing.Point(335, 425)
        Me.SpaceShipPosition.Name = "SpaceShipPosition"
        Me.SpaceShipPosition.Size = New System.Drawing.Size(60, 53)
        Me.SpaceShipPosition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpaceShipPosition.TabIndex = 1
        Me.SpaceShipPosition.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(169, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "x"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(744, 508)
        Me.Controls.Add(Me.AlienPlane)
        Me.Controls.Add(Me.EarthImage)
        Me.Controls.Add(Me.PlayerScorePanel)
        Me.Controls.Add(Me.EnemyPosition7)
        Me.Controls.Add(Me.EnemyPosition6)
        Me.Controls.Add(Me.EnemyPosition5)
        Me.Controls.Add(Me.EnemyPosition3)
        Me.Controls.Add(Me.EnemyPosition2)
        Me.Controls.Add(Me.EnemyPosition1)
        Me.Controls.Add(Me.SpaceShipPosition)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.PlayerScorePanel.ResumeLayout(False)
        Me.PlayerScorePanel.PerformLayout()
        CType(Me.AlienPlane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EarthImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LifeImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyPosition7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyPosition6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyPosition5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyPosition3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyPosition2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyPosition1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceShipPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents SpaceShipPosition As System.Windows.Forms.PictureBox
    Friend WithEvents EnemyPosition1 As System.Windows.Forms.PictureBox
    Friend WithEvents EnemyPosition2 As System.Windows.Forms.PictureBox
    Friend WithEvents EnemyPosition3 As System.Windows.Forms.PictureBox
    Friend WithEvents EnemyPosition5 As System.Windows.Forms.PictureBox
    Friend WithEvents EnemyPosition6 As System.Windows.Forms.PictureBox
    Friend WithEvents EnemyPosition7 As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerScorePanel As System.Windows.Forms.Panel
    Friend WithEvents ScoreText As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EarthImage As System.Windows.Forms.PictureBox
    Friend WithEvents DistanceEarthCounter As System.Windows.Forms.Label
    Friend WithEvents DistanceFromEartText As System.Windows.Forms.Label
    Friend WithEvents AlienPlane As System.Windows.Forms.PictureBox
    Friend WithEvents LifeImage As System.Windows.Forms.PictureBox
    Friend WithEvents LevelLabel As System.Windows.Forms.Label
    Friend WithEvents LevelText As System.Windows.Forms.Label
    Friend WithEvents LifeCounter As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
End Class
