using API_CSharp.Context;
using API_CSharp.Models;
using API_CSharp.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

var ProdutoRepository = new ProdutoRepository();

using var db = new ProdutoContext();
app.MapGet("/", () => db.DbPath);

app.MapGet("/ListarProdutos", () => Results.Ok(ProdutoRepository.ListarProdutos()));

app.MapPost("/CadastrarProdutos", (Produto produto) => { 
    ProdutoRepository.CadastrarProduto(produto);

});

app.UseSwaggerUI();

app.Run();
