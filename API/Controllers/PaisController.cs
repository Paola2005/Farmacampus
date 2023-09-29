using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastuctura.Data;
using Infrastuctura.UnityOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

public class PaisController : BaseController
{
    private readonly IUnitOfWork _unitofwork;

    public PaisController(IUnitOfWork unitofwork)
    {
        _unitofwork = unitofwork;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<Pais>>> Get()
    {
        var nameVar = await _unitofwork.Paises.GetAllAsync();
        return Ok(nameVar);
    }
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Pais>> Get(int id)
    {
        var pais = await _unitofwork.Paises.GetByIdAsync(id);
        if (pais == null)
        {
            return NotFound();
        }
        return Ok(pais);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pais>> Post(Pais pais)
    {
        this._unitofwork.Paises.Add(pais);
        await _unitofwork.SaveAsync();
        if (pais == null)
        {
            return BadRequest();
        }
        return CreatedAtAction(nameof(Post), new { id = pais.Id }, pais);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<Pais>> Put(int id, [FromBody] Pais pais)
    {
        /* var paisTemp = await _unitofwork.Paises.GetByIdAsync(id); */
        if (pais.Id == 0)
        {
            pais.Id = id;
        }
        if (pais.Id != id)
        {
            return BadRequest();
        }
        if (pais == null)
        {
            return NotFound();
        }
        _unitofwork.Paises.Update(pais);
        await _unitofwork.SaveAsync();
        return Ok(pais);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pais>> Delete(int id)
    {
        var pais = await _unitofwork.Paises.GetByIdAsync(id);
        if (pais == null)
        {
            return NotFound();
        }
        _unitofwork.Paises.Remove(pais);
        await _unitofwork.SaveAsync();
        return NoContent();

    }


}
