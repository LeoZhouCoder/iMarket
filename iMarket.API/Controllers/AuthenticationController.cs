using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
//using MongoDB.Bson;
//using RawRabbit;
using System.Collections.Generic;
using iMarket.API.Commands;
//using UserRole = Talent.Core.UserRole;

namespace iMarket.API.Controllers
{
    public class AuthenticationController : Controller
    {
        public AuthenticationController() { }
        public IActionResult Get()
        {
            return Content("Hello from iMarket Api");
        }

        /// <summary>
        /// Create a new account
        /// </summary>
        /// <remarks>
        /// Creates an new account for user
        /// </remarks>
        /// <param name="command">CreateUser Model</param>
        /// <response code="201">Successful. Redirects to home page with successful message</response>
        /// <response code="400">BadRequest. User input model is invalid or Email is already registered</response>   
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [HttpPost("register")]
        public async Task<IActionResult> SignUp([FromBody]CreateUser command)
        {
            // mongodb+srv://iMarket:Pa$$w0rd@cluster-oe4xu.mongodb.net/test?retryWrites=true&w=majority
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new
                    {
                        Message = ModelState.Values.SelectMany(e => e.Errors.Select(m => m.ErrorMessage))
                    });
                }

                //check if username is unique
                /*bool isUniqueEmail = await _authenticationService.UniqueEmail(command.Email);
                if (!isUniqueEmail)
                {
                    return BadRequest(new { Message = "This email address is already in use by another account." });
                }*/

                // Check if password and confirm password match
                /*if (command.Password != command.ConfirmPassword)
                {
                    return BadRequest(new { Message = "The password fields don't match, please try again." });
                }*/

                //var authenticatedToken = new JsonWebToken();
                //authenticatedToken = await _authenticationService.SignUp(command);



                //return Ok(new { Success = true, Token = authenticatedToken });
                return Ok();
            }
            catch (ApplicationException e)
            {
                return BadRequest(new { e.Message });
            }
            catch (Exception)
            {
                return BadRequest(new { Message = "Please contact the IT Department for futher information" });
            }
        }
    }
}
