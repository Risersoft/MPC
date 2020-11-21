@imports risersoft.shared.cloud.common
@Code
    ViewData("Title") = "Home Page"
    Dim baseUrl As String = Request.Url.Scheme & "://" & Request.Url.Authority & Request.ApplicationPath.TrimEnd("/")
    Dim banner As String = risersoft.shared.GlobalCore.GetConfigSetting("banner")
    If String.IsNullOrEmpty(banner) Then banner = "/Content/images/MPC-banner.jpg" Else banner = baseUrl & banner

End Code
<div class="row imchn" style="margin-bottom:47px">
    <div class="col-md-8">
        <img src="@banner" style="width:650px;" class="img-responsive banner-img">
    </div>
    <div class="col-md-3 gst-banner-text">
        <h1 class="gst-banner-text-title">MPCNirvana</h1>
        <p class="lead gst-banner-text-para">Manufacturing Planning Control.</p>
        <p><a href="/app" class="btn btn-primary btn-lg">Start Now &raquo;</a></p>

        @*<div class="col-md-12" style="margin-top:85px;">
            <a href="#playstore" target="_blank"><img class="play" src="~/Content/images/playstore-button.png" style="width:100px;"></a>&nbsp;
            <a href="#appstore" target="_blank"><img class="app" src="~/Content/images/appstore-button.png" style="width:100px;"></a>
        </div>*@
    </div>
</div>
<div class="row clsimgb">
    <div class="col-md-3 footer-nav footer-text">
        <div class="clsfoot">
            <h2>Product Definition</h2>
            <p>
                Ensure that you have the right bill-of-materials and processes to make the right products.
            </p>
        </div>
    </div>
    <div class="col-md-3 footer-nav footer-text">
        <div class="clsfoot">
            <h2>Planning</h2>
            <p>
                Efficiently use capacity and determine material requirements.
            </p>
        </div>
    </div>
    <div class="col-md-3 footer-nav footer-text">
        <div class="clsfoot">
            <h2>Monitoring</h2>
            <p>Track, analyze, and control the plan that was released to the shop floor. Incentivize workforce.</p>
        </div>
    </div>
    <div class="col-md-3 footer-text">
        <div class="clsfoot">
            <h2>Multi Platform</h2>
            <p>Securely access your cloud hosted data from desktop, web & mobile.</p>
        </div>
    </div>
</div>
