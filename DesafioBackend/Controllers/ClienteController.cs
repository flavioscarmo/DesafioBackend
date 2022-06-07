﻿using DesafioBackend.Data;
using DesafioBackend.Model;
using DesafioBackend.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace DesafioBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;

        public ClienteController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteModel>>> Get(int id)
        {
            try
            {
                var cliente = await _context.Clientes.FindAsync(id);

                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpPost]
        public async Task<ActionResult<List<ClienteModel>>> Create(ClienteModel cliente)
        {
            try
            {
                var newCliente = new ClienteModel
                {
                    Ativo = cliente.Ativo,
                    Nome = cliente.Nome,
                    Cnpj = cliente.Cnpj,
                    Planta = cliente.Planta,
                    PessoaResponsavel = cliente.PessoaResponsavel,
                    Email = cliente.Email,
                    Ddd = cliente.Ddd,
                    Telefone = cliente.Telefone,
                    TipoDeCliente = cliente.TipoDeCliente,
                };

                _context.Clientes.Add(newCliente);
                await _context.SaveChangesAsync();

                return Ok(await Get(newCliente.Id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public async Task<ActionResult<ClienteModel>> Update(ClienteModel cliente)
        {

            var clienteUp = await _context.Clientes.FindAsync(cliente.Id);

            if (clienteUp == null)
            {
                return NotFound(cliente);
            }

            clienteUp.Ativo = cliente.Ativo;
            clienteUp.Nome = cliente.Nome; 
            clienteUp.Cnpj = cliente.Cnpj;
            clienteUp.Planta = cliente.Planta;
            clienteUp.PessoaResponsavel = cliente.PessoaResponsavel;
            clienteUp.Email = cliente.Email;
            clienteUp.TipoDeCliente = cliente.TipoDeCliente;
            clienteUp.Ddd = cliente.Ddd;
            clienteUp.Telefone = cliente.Telefone;

            _context.Clientes.Update(clienteUp);
            await _context.SaveChangesAsync();

            return Ok(await Get(clienteUp.Id));
        }
    }
}
