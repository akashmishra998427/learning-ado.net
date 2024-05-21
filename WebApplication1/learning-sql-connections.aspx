<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="learning-sql-connections.aspx.cs" Inherits="WebApplication1.learning_sql_connections" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" class="gridview"></asp:GridView>

        </div>
    </form>
</body>
</html>
