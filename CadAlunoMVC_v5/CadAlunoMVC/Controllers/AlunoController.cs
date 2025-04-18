using CadAlunoMVC.DAO;
using CadAlunoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CadAlunoMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                AlunoDAO dao = new AlunoDAO();
                var lista = dao.Listagem();
                return View("index", lista);
            }
            catch (Exception erro)
            {
                return View("error", new ErrorViewModel(erro.ToString()));
            }
        }


        public IActionResult Create()
        {
            try
            {
                ViewBag.Operacao = "I";
                AlunoViewModel aluno = new AlunoViewModel();
                aluno.DataNascimento = DateTime.Now;
                AlunoDAO dao = new AlunoDAO();
                aluno.Id = dao.ProximoId();
                return View("Form", aluno);
            }
            catch (Exception erro)
            {
                return View("error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Salvar(AlunoViewModel aluno, string operacao)
        {
            try
            {
                AlunoDAO dao = new AlunoDAO();
                
                ValidaDados(aluno, operacao);
                if (ModelState.IsValid)
                {
                    if (operacao == "I")
                        dao.Inserir(aluno);
                    else
                        dao.Alterar(aluno);
                    return RedirectToAction("index");
                }
                else
                {
                    ViewBag.Operacao = operacao;
                    return View("form", aluno);
                }
            }
            catch (Exception erro)
            {
                return View("error", new ErrorViewModel(erro.ToString()));
            }
        }

        private void ValidaDados(AlunoViewModel aluno, string operacao)
        {
            ModelState.Clear(); // limpa os erros criados automaticamente pelo Asp.net (que podem estar com msg em inglês)
            AlunoDAO dao = new AlunoDAO();
            if (aluno.Id <= 0)
                ModelState.AddModelError("Id", "Id inválido!");
            else
            {
                if (operacao == "I" && dao.Consulta(aluno.Id) != null)
                    ModelState.AddModelError("Id", "Código já está em uso.");
                if (operacao == "A" && dao.Consulta(aluno.Id) == null)
                    ModelState.AddModelError("Id", "Aluno não existe.");
            }

            if (string.IsNullOrEmpty(aluno.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome.");
            if (aluno.Mensalidade < 0)
                ModelState.AddModelError("Mensalidade", "Campo obrigatório.");
            if (aluno.CidadeId <= 0)
                ModelState.AddModelError("CidadeId", "Informe o código da cidade.");
            if (aluno.DataNascimento > DateTime.Now)
                ModelState.AddModelError("DataNascimento", "Data inválida!");
        }


        public IActionResult Edit(int id)
        {
            try
            {
                ViewBag.Operacao = "A";
                AlunoDAO dao = new AlunoDAO();
                AlunoViewModel aluno = dao.Consulta(id);
                if (aluno == null)
                    return RedirectToAction("index");
                else
                    return View("Form", aluno);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                AlunoDAO dao = new AlunoDAO();
                dao.Excluir(id);
                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

    }
}
