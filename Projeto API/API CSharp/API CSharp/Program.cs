using API_CSharp.Models;
using API_CSharp.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();

var ProdutoRepository = new ProdutoRepository();

app.MapGet("/", () => "Hello World!");

app.MapGet("/ListarProdutos", () => Results.Ok(ProdutoRepository.ListarProdutos()));

app.MapPost("/CadastrarProdutos", (Produto produto) => Results.Ok(ProdutoRepository.CadastrarProduto(produto)));

app.UseSwaggerUI();

app.Run();
