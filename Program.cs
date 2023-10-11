﻿using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new(nome: "Hóspede 1");
Pessoa p2 = new(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 10, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new(diasReservados: 15);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe as informações da estadia
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Tipo de Suíte: {reserva.Suite.TipoSuite}");
Console.WriteLine($"Valor total: R${reserva.CalcularValorDiaria()}");