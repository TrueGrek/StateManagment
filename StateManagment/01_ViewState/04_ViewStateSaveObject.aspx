<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="04_ViewStateSaveObject.aspx.cs"
    Inherits="StateManagment._01_ViewState.ViewStateSaveObject" ViewStateEncryptionMode="Always" %>
    <%--
    По умолчани ViewState отправляется в не зашифрованном виде.
    Что бы Включить шифрование используется следующий атрибут ViewStateEncryptionMode
    "Always" - шифровать все данные во ViewStat при каждом запросе/ответе
    "Never"  - не шифровать данные
    "Auto"   - (по умолчанию) шифровать только де данные ViewState, которые относятся к контролам запросившим шифрование
    свойе части информации во ViewState--%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View State #4</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="WriteButton" Text="Записать во ViewState" runat="server" OnClick="WriteButton_Click" />
        <asp:Button ID="ReadButton" Text="Прочитать из ViewState" runat="server" OnClick="ReadButton_Click" />
        <br />
        <br />
        <b>UserName: </b>
        <asp:Label ID="UserNameLabel" runat="server" /><br />
        <b>Email: </b>
        <asp:Label ID="EmailLabel" runat="server" /><br />
    </div>
    </form>
</body>
</html>
