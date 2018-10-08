using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zinix.Dtos;
using Zinix.Models;

namespace Zinix.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        
        //api/rentals/
        [HttpPost]
        public IHttpActionResult NewRentals(RentalDto rentalDto)
        {
            var customer = _context.Customers
                .Single(c => c.Id == rentalDto.CustomerId);
            var movies = _context.Movies.Where(m => rentalDto.MovieIds.Contains(m.Id));

            foreach(Movie movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is unavailable!");

                movie.NumberAvailable--;

                var newRental = new Rental()
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(newRental);
            }
            
            _context.SaveChanges();

            return Ok();
        }
    }
}
