<%@ Page Title="" Language="C#" MasterPageFile="~/anonimo.Master" AutoEventWireup="true" CodeBehind="registo.aspx.cs" Inherits="GDocumental.registo" %>
<asp:Content ID="registo" ContentPlaceHolderID="conteudoPagina" runat="server">
        <!-- Page Header -->
    <!-- Set your background image for this header on the line below. -->
    <header class="intro-header" style="background-image: url('img/registo-bg.jpg')">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                    <div class="page-heading">
                        <h1>Registo de Conta</h1>
                        <hr class="small">
                        <span class="subheading">Publique o seu Documento: Registe-se...</span>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- Main Content -->
    <div class="container">
        <div class="row">
            <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                <p>Crie a sua Conta no Portal Docs 4 ALL:</p>
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>Nome</label>
                            <input type="text" class="form-control" placeholder="Nome Completo" name="txtNome" id="txtNome" required>
                            <p class="help-block text-danger"></p>
                        </div>
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>eMail</label>
                            <input type="email" class="form-control" placeholder="Email" name="txtEmail" id="txtEmail" required>
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>Senha</label>
                            <input type="password" class="form-control" placeholder="Senha" name="txtSenha" id="txtSenha" required>
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <div class="row control-group">
                        <div class="form-group col-xs-12 floating-label-form-group controls">
                            <label>Senha</label>
                            <input type="password" class="form-control" placeholder="Confirme Senha" name="txtConfirmacaoSenha" id="txtConfirmacaoSenha" required>
                            <p class="help-block text-danger"></p>
                        </div>
                    </div>
                    <br>
                    <div id="success"></div>
                    <div class="row">
                        <div class="form-group col-xs-12">
                            <asp:Button id="submit" runat="server" Text="Criar Registo" onclick="submit_Click" class="btn btn-default"/>
                        </div>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
