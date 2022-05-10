using AutoMapper;
using HW3.Controllers.Models;
using HW3.Repositories;
using HW3.Requests;
using HW3.Responses;
using HW3.Validation;
using HW3.Validation.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HW3.Controllers
{
    [Route("api/customer")]
    [Authorize]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IMapper _mapper;
        private IPersonsRepository _personsRepository;        
        private IGetPersonsByIdValidator _getPersonsByIdValidator;
        private ICreatePersonsValidator _createPersonsValidator;
        private IDeletePersonsValidator _deletePersonsValidator;

        public PersonsController(
            IPersonsRepository personsRepository,
            IMapper mapper,
            IGetPersonsByIdValidator getPersonsByIdValidator,
            ICreatePersonsValidator createPersonsValidator,
            IDeletePersonsValidator deletePersonsValidator)
        {
            _personsRepository = personsRepository;            
            _mapper = mapper;
            _getPersonsByIdValidator = getPersonsByIdValidator;
            _createPersonsValidator = createPersonsValidator;
            _deletePersonsValidator = deletePersonsValidator;
        }

        [HttpGet("get/all")]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _personsRepository.GetAll();
            var response = new GetAllPersonsResponse()
            {
                Persons = new List<PersonsDto>()
            };

            foreach (Persons customer in customers)
            {
                response.Persons.Add(_mapper.Map<PersonsDto>(customer));
            }

            return Ok(response);
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetById([FromRoute] long id)
        {
            var request = new GetPersonsByIdRequest { Id = id };
            var validation = new OperationResult<GetPersonsByIdRequest>(_getPersonsByIdValidator.ValidateEntity(request));

            if (!validation.Succeed)
            {
                return BadRequest(validation);
            }

            var customer = await _personsRepository.GetById(request);
            var response = new GetPersonsByIdResponse();

            response.Persons = _mapper.Map<PersonsDto>(customer);

            return Ok(response);
        }

        [HttpPost("create/{name}")]
        public async Task<IActionResult> Create([FromRoute] string name)
        {
            var request = new CreatePersonsRequest { Name = name };
            var validation = new OperationResult<CreatePersonsRequest>(_createPersonsValidator.ValidateEntity(request));

            if (!validation.Succeed)
            {
                return BadRequest(validation);
            }

            await _personsRepository.Create(request);
            return Ok();
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute] long id)
        {
            var request = new DeletePersonsRequest { Id = id };
            var validation = new OperationResult<DeletePersonsRequest>(_deletePersonsValidator.ValidateEntity(request));

            if (!validation.Succeed)
            {
                return BadRequest(validation);
            }

            await _personsRepository.Delete(request);
            return Ok();
        }
        

        [HttpGet("get/{customerId}/persons/{id}")]
        public async Task<IActionResult> GetpersonById([FromRoute] long customerId, [FromRoute] long id)
        {
            var request = new GetPersonsByIdRequest { PersonsId = customerId, Id = id };
            var validation = new OperationResult<GetPersonsByIdRequest>(_getPersonsByIdValidator.ValidateEntity(request));

            if (!validation.Succeed)
            {
                return BadRequest(validation);
            }

            var person = await _personsRepository.GetById(request);
            var response = new GetPersonsByIdResponse();

            response.Persons = _mapper.Map<PersonsDto>(person);

            return Ok(response);
        }

        [HttpPost("create/{customerId}/person/{name}")]
        public async Task<IActionResult> Createperson([FromRoute] long customerId, [FromRoute] string name)
        {
            var request = new CreatePersonsRequest { PersonsId = customerId, Name = name };
            var validation = new OperationResult<CreatePersonsValidator>(_createPersonsValidator.ValidateEntity(request));

            if (!validation.Succeed)
            {
                return BadRequest(validation);
            }

            await _personsRepository.Create(request);
            return Ok();
        }

        [HttpDelete("delete/{customerId}/person/{id}")]
        public async Task<IActionResult> Deleteperson([FromRoute] long customerId, [FromRoute] long id)
        {
            var request = new DeletePersonsRequest { PersonsId = customerId, Id = id };
            var validation = new OperationResult<GetPersonsByIdRequest>(_deletePersonsValidator.ValidateEntity(request));

            if (!validation.Succeed)
            {
                return BadRequest(validation);
            }

            await _personsRepository.Delete(request);
            return Ok();
        }
    }
}