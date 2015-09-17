<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="Scripts/jquery-1.8.2.min.js"></script>
    <script type="text/javascript">
        function testfun()
        {
            alert("OK");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" value="测试" onclick="testfun();" />
        </div>
    </form>
</body>
</html>
