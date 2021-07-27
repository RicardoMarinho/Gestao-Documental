<%@ Page Title="" Language="C#" MasterPageFile="~/anonimo.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GDocumental.login" %>
<asp:Content ID="login" ContentPlaceHolderID="conteudoPagina" runat="server">
        <!-- Page Header -->
    <!-- Set your background image for this header on the line below. -->
    <header class="intro-header" style="background-image: url('img/login-bg.jpg')">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                    <div class="page-heading">
                        <h1>AUTENTIQUE-SE</h1>
                        <hr class="small">
                        <span class="subheading">Utilize o seu email e senha para publicar Documentos</span>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- Main Content -->
    <div class="container">
        <div class="row">
            <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                <p>Acesso ao Portal:</p>
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>eMail</label>
                            <input type="email" class="form-control" placeholder="Email" name="txtEmail" id="txtEmail" required data-validation-required-message="Por favor indique o seu Email.">
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>Senha</label>
                            <input type="password" class="form-control" placeholder="Senha" name="txtSenha" id="txtSenha" required data-validation-required-message="Por favor indique a sua Senha.">
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <br>
                    <div id="success"></div>
                    <div class="row">
                        <div class="form-group col-xs-12">
                            <button id="submit" type="submit" name="submit" class="btn btn-default">Entrar</button>
                        </div>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
