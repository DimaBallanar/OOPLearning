﻿using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using OnlineShop.Repository;

namespace OnlineShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository m_userRepository;
        public UserController(UserRepository userRepository)
        {
            m_userRepository = userRepository;
        }

        //https://localhost:7172/api/User
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(m_userRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //https://localhost:7172/api/User/get/1
        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(m_userRepository.GetAll(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post(User user) 
        {
            try
            {
                return Ok(m_userRepository.Put(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}