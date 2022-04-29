using FluentAssertions;
using N5.Application.UseCases.Permission.Save;
using N5.Application.UseCases.Permission.Update;
using N5.Common.Helpers;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace N5.Test
{
    public class PermissionTest:IntegrationTest
    {   
        public PermissionTest():base()
        {           
            
        }
        

        [Fact]
        public async Task GetPermissions_With_non_existent_code_returns_not_found()
        {
            //call service GetPermissions
            var response = await _httpClient.GetAsync("permissions/GetPermission/0");
            //check answer
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);                     
        }


        [Fact]
        public async Task GetPermissions_of_an_existing_code_should_be_success()
        {
            //create a new request
            var request = new SavePermissionRequest { Name = "Permission 13", PermissionTypeId = 1 };
            //execute post call
            var objectResponse = await ExecutePostCall(request);
            //check answer
            objectResponse.Should().NotBeNull();
            //call service GetPermissions with an exsisting object
            var response = await _httpClient.GetAsync($"permissions/GetPermission/{objectResponse.Data.Id}");
            //check the service's answer
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            var getResponse = await response.Content.ReadAsAsync<Response<SavePermissionResult>>();
            getResponse.Succeeded.Should().BeTrue();

        }

        [Fact]
        public async Task Request_new_permissions_should_be_success()
        {
            //crea a new reuest object
            var request = new SavePermissionRequest { Name = "Permission 13", PermissionTypeId = 1 };
            //call RequestPermission service
            var objectResponse = await ExecutePostCall(request);
            //check the service's answer
            objectResponse.Succeeded.Should().BeTrue();          
        }

        [Fact]
        public async Task ModifyPermissions_with_existing_code_should_be_sucess()
        {
            // Execute post call
            var request = new SavePermissionRequest { Name = "Permission 13", PermissionTypeId = 1 };
            var objectResponse = await ExecutePostCall(request);
            objectResponse.Should().NotBeNull();
            // Alter some data
            var dataModified = objectResponse.Data;
            dataModified.Name = "Name modified";
            //call ModifiyPermission service
            var putResponse = await ExecutePutCall(dataModified);
            //check the service's answer
            putResponse.Succeeded.Should().BeTrue();
            putResponse.Data.Should().NotBeNull();
            putResponse.Data.Name.Should().Be(dataModified.Name);

        }

        private async Task<Response<SavePermissionResult>> ExecutePostCall(SavePermissionRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("permissions/RequestPermission", request);
            var objectResponse = await response.Content.ReadAsAsync<Response<SavePermissionResult>>();
            return objectResponse;
        }

        private async Task<Response<UpdatePermissionResult>> ExecutePutCall(SavePermissionResult saveRequest)
        {
            var request = new UpdatePermissionRequest
            {
                Id = saveRequest.Id,
                Name = saveRequest.Name,
                PermissionTypeId = saveRequest.PermissionTypeId
            };

            var response = await _httpClient.PutAsJsonAsync($"permissions/ModifyPermission/{request.Id}", request);
            var objectResponse = await response.Content.ReadAsAsync<Response<UpdatePermissionResult>>();
            return objectResponse;
        }
    }
}
