using AirTransferLines.Business.Abstract;
using AirTransferLines.Entities;
using AirTransferLines.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirTransferLines.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        IAcenteService _acenteService;
        ITransferService _transferService;
        IRezervasyonService _rezervasyonService;
        IAuthService _authService;

        public AdminController(IAcenteService acenteService,ITransferService transferService,
            IRezervasyonService rezervasyonService,IAuthService authService)
        {
            _acenteService = acenteService;
            _transferService = transferService;
            _rezervasyonService = rezervasyonService;
            _authService = authService;
        }


        //Acente islemleri baslangıc


        [HttpGet("getacentedetails")]
        
        public IActionResult GetAcenteDetails()
        {
           

            var result = _acenteService.GetAcenteDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("acenteadd")]
        public IActionResult AcenteAdd(Acente acente)
        {

            var result = _acenteService.Add(acente);
            var a = result;
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("acenteupdate")]
        public IActionResult AcenteUpdate(Acente acente)
        {

            var result = _acenteService.Update(acente);
            
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("acentedelete")]

        public IActionResult AcenteDelete(Acente acente)
        {
            var result = _acenteService.Delete(acente);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getacentedetailsbyId")]
        public IActionResult GetAcenteDetailsById(int ID)
        {
            var result = _acenteService.GetAcenteDetailsById(ID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


        //Transfer İslemi Baslangıcı


        [HttpGet("gettransferdetails")]

        public IActionResult GetTransferDetails()
        {


            var result = _transferService.GetTransferDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("transferadd")]
        public IActionResult TransferAdd(Transfer transfer)
        {

            var result = _transferService.Add(transfer);
            var a = result;
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("transferupdate")]
        public IActionResult TransferUpdate(Transfer transfer)
        {

            var result = _transferService.Update(transfer);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("transferdelete")]

        public IActionResult TransferDelete(Transfer transfer)
        {
            var result = _transferService.Delete(transfer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("gettransferdetailsbyId")]
        public IActionResult GetTransferDetailsById(int ID)
        {
            var result = _transferService.GetTransferDetailsById(ID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


        //Rezervasyon İslemi Baslangıcı

        [HttpGet("getrezervasyondetails")]

        public IActionResult GetRezervasyonDetails()
        {


            var result = _rezervasyonService.GetRezervasyonDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("rezervasyonadd")]
        public IActionResult RezervasyonAdd(Rezervasyon rezervasyon)
        {

            var result = _rezervasyonService.Add(rezervasyon);
            var a = result;
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("rezervasyonupdate")]
        public IActionResult RezervasyonUpdate(Rezervasyon rezervasyon)
        {

            var result = _rezervasyonService.Update(rezervasyon);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("rezervasyondelete")]

        public IActionResult RezervasyonDelete(Rezervasyon rezervasyon)
        {
            var result = _rezervasyonService.Delete(rezervasyon);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getrezervasyondetailsbyId")]
        public IActionResult GetRezervasyonDetailsById(int ID)
        {
            var result = _rezervasyonService.GetRezervasyonDetailsById(ID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("bystatustrue")]
        public IActionResult ByStatusTrue(bool status)
        {
            var result = _rezervasyonService.ByStatusTrue(status);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("bystatusfalse")]
        public IActionResult ByStatusFalse(bool status)
        {
            var result = _rezervasyonService.ByStatusFalse(status);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }


        //Authentication İslemleri

        [HttpPost("login")]
        public ActionResult Login(UyeForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Message);
        }


        [HttpPost("register")]
        public ActionResult Register(UyeForRegisterDto userForRegisterDto)
        {
            //var userExists = _authService.UserExists(userForRegisterDto.Email);
            //if (!userExists.success)
            //{
            //    return BadRequest(userExists.Message);
            //}

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


    }
}
