﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Multishop.WebDTO.DTOs.OrderDtos.AddressDtos;
using Multishop.WebUI.Services.Interfaces;
using Multishop.WebUI.Services.OrderServices.AddressServices;

namespace Multishop.WebUI.Controllers
{
	
	public class OrderController(IAddressService _addressService,IUserService _userService) : Controller
	{
		[HttpGet]
		public async Task<IActionResult> Index()
		{
            var user = await _userService.GetUserInfo();
            ViewBag.city = user.City;
            ViewBag.name = user.Name;
            ViewBag.surname = user.Surname;
            ViewBag.email = user.Email;
            return View();
		}


		[HttpPost]
		public async Task<IActionResult> CreateAddress(CreateAddressDto createAddressDto)
		{
			var user = await _userService.GetUserInfo();
			createAddressDto.UserId = user.Id;
			await _addressService.CreateAddressAsync(createAddressDto);
			return RedirectToAction("Index");
		}
	}
}
