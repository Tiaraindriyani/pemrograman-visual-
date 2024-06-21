<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormData
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataPembeliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New fancell_UAS.DataSet1()
        Me.DataBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataPembeliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTransaksiBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "fancell_UAS.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(69, 38)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1113, 419)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataPembeliBindingSource
        '
        Me.DataPembeliBindingSource.DataMember = "DataPembeli"
        Me.DataPembeliBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBarangBindingSource
        '
        Me.DataBarangBindingSource.DataMember = "DataBarang"
        Me.DataBarangBindingSource.DataSource = Me.DataSet1
        '
        'DataTransaksiBindingSource
        '
        Me.DataTransaksiBindingSource.DataMember = "DataTransaksi"
        Me.DataTransaksiBindingSource.DataSource = Me.DataSet1
        '
        'FormData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 514)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormData"
        Me.Text = "FormData"
        CType(Me.DataPembeliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataPembeliBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As fancell_UAS.DataSet1
    Friend WithEvents DataBarangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTransaksiBindingSource As System.Windows.Forms.BindingSource
End Class
