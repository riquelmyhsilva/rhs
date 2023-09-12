<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="rhs.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="~/Content/src/css/contact-style.css" />
    <link rel="stylesheet" href="~/Content/src/css/base-website-style.css" />
    <link rel="shortcut icon" href="~/Content/src/favicon/favicon-r.ico" type="image/x-icon" />
    <script src="~/Content/src/js/contact-script.js"></script>
    <title>contact</title>
</head>
<body>
    <header class="menu">
        <main>
            <a href="/Home/Index" class="logo button">rhs</a>
            <div class="menu-buttons-header">
                <a href="/Home/Index#projects" class="nav-button button">work</a>
                <a href="/Home/AboutMe" class="nav-button button">about me</a>
                <a href="/Home/Contact" class="nav-button button">contact</a>
            </div>
        </main>
    </header>
    <div class="divisor"></div>
    <main class="main-content">
        <p class="tittle-main">contact</p>
        <h1 class="content-main">I feel flattered and excited to start a new job. Let's go work togheter.
        </h1>
        <a href="#" class="email">riquelmyhs13@gmail.com</a>
    </main>
    <div class="divisor"></div>
    <main class="main-content">
        <div class="client-email">
            <p class="tittle-email">or let me get in touch with you</p>
            <div class="email-box">
                <form id="emailForm" runat="server">
                    <asp:TextBox runat="server" ID="emailAdress" class="email-text" placeholder ="your e-mail" OnTextChanged="emailAdress_TextChanged"></asp:TextBox>
                    <asp:Button runat="server" Text="send" class="button button-send-email" OnClick="send_Click" ID="sendButton"></asp:Button>
                </form>
            </div>
        </div>
    </main>
    <footer>
        <main class="main-footer">
            <p id="license">© rhs 2023</p>
            <div class="menu-buttons-footer">
                <a href="/Home/Index" class="nav-button-footer button">home</a>
                <a href="/Home/Index#projects" class="nav-button button">work</a>
                <a href="/Home/AboutMe" class="nav-button button">about me</a>
                <a href="/Home/Contact" class="nav-button button">contact</a>
            </div>
        </main>
    </footer>
</body>
</html>
