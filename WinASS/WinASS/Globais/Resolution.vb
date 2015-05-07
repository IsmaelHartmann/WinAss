Option Explicit On 

Public Class Resolution
    Const CCDEVICENAME As Short = 32
    Const CCFORMNAME As Short = 32
    Const DM_BITSPERPEL As Integer = &H40000
    Const DM_PELSWIDTH As Integer = &H80000
    Const DM_PELSHEIGHT As Integer = &H100000
    Const CDS_UPDATEREGISTRY As Short = &H1S
    Const CDS_TEST As Short = &H4S
    Const DISP_CHANGE_SUCCESSFUL As Short = 0
    Const DISP_CHANGE_RESTART As Short = 1
    Const BITSPIXEL As Short = 12

    Private Structure DEVMODE
        <VBFixedString(CCDEVICENAME), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=CCDEVICENAME)> Public dmDeviceName As String
        Dim dmSpecVersion As Short
        Dim dmDriverVersion As Short
        Dim dmSize As Short
        Dim dmDriverExtra As Short
        Dim dmFields As Integer
        Dim dmOrientation As Short
        Dim dmPaperSize As Short
        Dim dmPaperLength As Short
        Dim dmPaperWidth As Short
        Dim dmScale As Short
        Dim dmCopies As Short
        Dim dmDefaultSource As Short
        Dim dmPrintQuality As Short
        Dim dmColor As Short
        Dim dmDuplex As Short
        Dim dmYResolution As Short
        Dim dmTTOption As Short
        Dim dmCollate As Short
        <VBFixedString(CCFORMNAME), System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst:=CCFORMNAME)> Public dmFormName As String
        Dim dmUnusedPadding As Short
        Dim dmBitsPerPel As Short
        Dim dmPelsWidth As Integer
        Dim dmPelsHeight As Integer
        Dim dmDisplayFlags As Integer
        Dim dmDisplayFrequency As Integer
    End Structure
    Private Declare Function GetDC Lib "user32" (ByVal hwnd As IntPtr) As IntPtr
    Private Declare Function GetDeviceCaps Lib "gdi32.dll" (ByVal hDC As IntPtr, ByVal nIndex As Long) As Long
    Private Const HORZRES = 8 ' Horizontal size in pixels
    Private Const VERTRES = 10 ' Vertical size in pixels

    'Private Const LOGPIXELSX = 88 ' Pixel/inch in X
    'Private Const LOGPIXELSY = 90 ' Pixel/inch in Y
    Public Shared Sub GetVideoCaps(ByVal hDC As IntPtr, ByVal Colors As Long, ByVal XResolution As Long, ByVal YResolution As Long, ByRef oldBitsPerPixel As Long)
        Dim i As Integer
        oldBitsPerPixel = GetDeviceCaps(hDC, BITSPIXEL)
        Colors = 1
        For i = 1 To oldBitsPerPixel
            Colors = Colors * 2
        Next
        XResolution = GetDeviceCaps(hDC, HORZRES)
        YResolution = GetDeviceCaps(hDC, VERTRES)
    End Sub

    Private Declare Function EnumDisplaySettings Lib "user32" Alias "EnumDisplaySettingsA" (ByVal lpszDeviceName As Integer, ByVal iModeNum As Integer, ByRef lpDevMode As DEVMODE) As Boolean
    Private Declare Function ChangeDisplaySettings Lib "user32" Alias "ChangeDisplaySettingsA" (ByRef lpDevMode As DEVMODE, ByVal dwFlags As Integer) As Integer

    Public Shared Sub GethDC(ByRef hDC As IntPtr)
        hDC = GetDC(IntPtr.Zero)
    End Sub
    Public Shared Sub ChangeRes(ByRef X As Integer, ByRef Y As Integer, ByRef Bits As Integer)
        Dim DevM As DEVMODE = Nothing
        Dim erg As Integer
        'Get the info into DevM 
        erg = EnumDisplaySettings(0, 0, DevM)
        'This is what we're going to change 
        Dim x1 As Integer
        x1 = DevM.dmPelsWidth
        DevM.dmFields = DM_PELSWIDTH Or DM_PELSHEIGHT Or DM_BITSPERPEL
        DevM.dmPelsWidth = X 'ScreenWidth 
        DevM.dmPelsHeight = Y 'ScreenHeight 
        DevM.dmBitsPerPel = Bits '(can be 8, 16, 24, 32 or even 4) 

        'Now change the display and check if possible 
        erg = ChangeDisplaySettings(DevM, CDS_TEST)
    End Sub

End Class

