<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDownList.aspx.cs" Inherits="CascadingDropDownListHard.DropDownList" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cascading Dropdown</title>

    <style>
        body {
            background: linear-gradient(135deg, #74ebd5, #9face6);
            font-family: Arial, sans-serif;
        }

        .container {
            width: 400px;
            margin: 120px auto;
            padding: 30px;
            background: white;
            border-radius: 12px;
            box-shadow: 0 8px 20px rgba(0,0,0,0.2);
            text-align: center;
        }

        h2 {
            color: #333;
            margin-bottom: 20px;
        }

        select {
            width: 90%;
            padding: 8px;
            margin: 10px 0;
            border-radius: 6px;
            border: 1px solid #ccc;
            font-size: 14px;
        }

        input[type=submit] {
            background: #4CAF50;
            color: white;
            border: none;
            padding: 10px 25px;
            border-radius: 6px;
            cursor: pointer;
            font-size: 15px;
            margin-top: 15px;
        }

        input[type=submit]:hover {
            background: #43a047;
        }

        .label {
            display: block;
            margin-top: 15px;
            color: #333;
            font-weight: bold;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Cascading Dropdown</h2>

            <asp:DropDownList ID="ddlCountries" runat="server" AutoPostBack="true"
                OnSelectedIndexChanged="ddlCountries_SelectedIndexChanged">
            </asp:DropDownList>

            <asp:DropDownList ID="ddlStates" runat="server" AutoPostBack="true"
                OnSelectedIndexChanged="ddlStates_SelectedIndexChanged">
            </asp:DropDownList>

            <asp:DropDownList ID="ddlCities" runat="server" AutoPostBack="true"
                OnSelectedIndexChanged="ddlCities_SelectedIndexChanged">
            </asp:DropDownList>

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

            <asp:Label ID="lblMessage" runat="server" CssClass="label"></asp:Label>
        </div>
    </form>
</body>
</html>