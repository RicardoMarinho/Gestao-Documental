<%@ Page Title="" Language="C#" MasterPageFile="~/anonimo.Master" AutoEventWireup="true" CodeBehind="exemplo.aspx.cs" Inherits="GDocumental.exemplo" %>
<asp:Content ID="exemplo" ContentPlaceHolderID="conteudoPagina" runat="server">
        <!-- Page Header -->
    <!-- Set your background image for this header on the line below. -->
    <header class="intro-header" style="background-image: url('img/post-bg.jpg')">
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                    <div class="page-heading">
                        <h1>Exemplo de Documento Publicado</h1>
                        <hr class="small">
                        <span class="subheading">Aprender Php</span>
                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- Post Content -->
    <article>
        <div class="container">
            <div class="row">
                <div class="col-lg-8 col-lg-offset-2 col-md-10 col-md-offset-1">
                    <p>Sem mais Lorem ipsum dolor sit amet</p>
                    <a href="#">
                        <img class="img-responsive" src="img/post-sample-image.jpg" alt="">
                    </a>
                    <p>Apenas um documento simples para lerem nos tempos livres</p>

                    <h2 class="section-heading">What a Big Subtitle</h2>

                    <p>E o Documento é:</p>

                    <blockquote>“ Luke, you're going to find that many of the truths we cling to, depend greatly on our own point of view.” <i>Obi Wan in Star Wars:)</i></blockquote>

                    <p>Uma apresentação do ASP.NET CORE</p>
                    <p><a href="/documentos/AspNetCoreIntro.pdf" target="_blank">Descarrega aqui</a></p>
                </div>
            </div>
        </div>
    </article>
</asp:Content>
