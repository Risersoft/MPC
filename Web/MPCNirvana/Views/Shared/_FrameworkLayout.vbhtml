@imports risersoft.shared.web.Extensions
@imports risersoft.shared.web
@imports risersoft.shared.portable
@imports risersoft.shared.cloud.common
@imports risersoft.shared.cloud
@imports risersoft.shared.agent

@Code
    Dim _user As RSUser = Nothing
    If (Not Me.User Is Nothing) AndAlso (Not Me.User.Identity Is Nothing) Then
        _user = OwinHelper.GetRSUser(Me.User.Identity)

    End If
    Dim portal As String = risersoft.shared.GlobalCore.GetConfigSetting("portal")
    Dim ctx = CType(ViewContext.Controller, IHostedController).myWebController
End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title")</title>
    @Scripts.Render("~/bundles/modernizr")
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    <link href="~/Scripts/jquery-ui/jquery-ui.css" rel="stylesheet" />
    @RenderSection("scripts", required:=False)
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/angular")


</head>
<body ng-app="rsApp">
    @*<div class="top-line">&nbsp;</div>*@
    @If Not _user Is Nothing Then
        @<div Class="top-header-navigation">
            <div class="container">

                <div class="btn-group margin-rgt10" style="float:right;margin-right: 22px;">
                    <a class="glyphicon glyphicon-user active" data-toggle="dropdown" style="text-decoration:none" href="#" aria-expanded="false">
                        <span class="caret"></span>
                    </a>
                    <ul class="dropdown-menu dropdown-men" style="left:-115px;">
                        <li> <a href="/account/change">Manage</a></li>
                        <li> <a href="/account/Logout">Logout</a></li>
                    </ul>
                </div>

                <div class="btn-group margin-rgt10" style="float:right;margin-right: 22px;">
                    <a class="" style="text-decoration:none" href="#" aria-expanded="false">
                        Welcome @_user.FullName
                    </a>
                </div>
            </div>
        </div>
    Else
        @<ul Class="header-item">
            <li>
                <a href="/Account/Login">Login</a>
            </li>
            <li>
                <a href="@portal/User/signup">Signup</a>
            </li>
        </ul>
    End If





    <div style="background:#ffffff">
        <div class="container">
            <div class="logo-header">
                <div class="pull-left mobo-widthtab"><a href="/index" class="link-underline"><h2 class="uni-logo" style="margin-top: 0px;"><img src="~/Content/images/Nirvana.png" class="ninja-logo" />MPCNirvana</h2></a></div>
                <div class="pull-right tagline mobo-widthtab">
                    <h2>Manufacturing Planning Control</h2>
                </div>
            </div>
        </div>
    </div>
    @Html.Menu(ctx)
    <div class="clsmargn">
        @RenderBody()
        <hr />
        <div id="dialogFilter" title="Filter">
        </div>
        <footer>
            <p>&copy; @DateTime.Now.Year - @ctx.App.objAppExtender.Publisher</p>
        </footer>
    </div>
    <ul id="id_context2" style="display: none;">
        <li data-command="action1">Fetching Data ...</li>
    </ul>
    @RenderSection("BotScripts", required:=False)


    <script type="text/javascript">
        $(document).ready(function () {
            $(window).bind('scroll', function () {
                if ($(window).scrollTop() > 69) {

                    $('.navbar-fixed-top').addClass('navbar-fixed-top-change');
                    $('.top-line-move').addClass('fixed');
                }
                else {

                    $('.navbar-fixed-top').removeClass('navbar-fixed-top-change');
                    $('.top-line-move').removeClass('fixed');
                }
            });

        });
        function tablehtml(table) {

            var thtml = "<tr>";
            for (var k in table[0]) {
                thtml += "<th>" + k + "</th>";
            }
            thtml += "</tr>";
            $.each(table, function (index, value) {
                var TableRow = "<tr>";
                $.each(value, function (key, val) {
                    TableRow += "<td>" + val + "</td>";
                });
                TableRow += "</tr>";
                thtml += TableRow;;
            });
            return thtml;
        }

    </script>
</body>
</html>
