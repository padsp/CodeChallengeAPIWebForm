<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Async="true" Inherits="CodeChallengeAPIWebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Accounts Coding Test</title>
    <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/meyer-reset/2.0/reset.min.css" />
    <link rel="stylesheet" type="text/css" href="Content/Main.css" />
</head>
<body>
    <section id="wrapper">
      <header>
        <div class="title-container">
          <h1>Coding Test</h1>
        </div>
      </header>

       <main class="content" id="home-content">
        <div class="content-title-container">
          <h2>Accounts</h2>
        </div>
        <section id="account-grid">
          <section class="account-column" id="active-account-column">
            <div class="account-container-title" id="active-account-container-title">
              <h3>Active</h3>
            </div>
            <div class="account-container" id="active_account" runat="server">
        </div>
        </section>
        <section class="account-column" id="overdue-account-column">
            <div class="account-container-title" id="overdue-account-container-title">
              <h3>Overdue</h3>
            </div>
        <div class="account-container" id="overdue_account" runat="server">
        </div>
        </section>
            <div class="account-column" id="inactive-account-column">
            <div class="account-container-title" id="inactive-account-container-title">
              <h3>Inactive</h3>
            </div>
        <div class="account-container" id="inactive_account" runat="server">
        </div>
        </div>
        </section>
           </main>
              <footer>
        <p class="copy">&copy;&nbsp;<script>document.write(new Date().getFullYear())</script></p>
      </footer>
        </section>
</body>
</html>
