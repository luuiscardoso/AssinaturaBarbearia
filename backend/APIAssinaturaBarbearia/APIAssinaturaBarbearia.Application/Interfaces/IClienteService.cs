﻿using APIAssinaturaBarbearia.Application.DTO;
using APIAssinaturaBarbearia.Domain.Entities;

namespace APIAssinaturaBarbearia.Application.Interfaces
{
    public interface IClienteService
    {
        Cliente RegistrarCliente(ClienteCadastroDTO clienteDto, Assinatura assinaturaCriada);
    }
}
