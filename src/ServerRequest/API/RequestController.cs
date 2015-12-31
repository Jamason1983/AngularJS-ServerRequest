using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ServerRequest.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerRequest.API
{
    [Route("api/[controller]")]
    public class RequestController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<Request> Get()
        {
            List<DriveConfig> driveConfig = new List<DriveConfig>();
            driveConfig.Add(new DriveConfig { Id = 0, Size = 60, DriveId = "C", DisplayName = "OS Drive" });
            driveConfig.Add(new DriveConfig { Id = 0, Size = 120, DriveId = "D", DisplayName = "OS Drive" });
            driveConfig.Add(new DriveConfig { Id = 0, Size = 400, DriveId = "E", DisplayName = "OS Drive" });
            driveConfig.Add(new DriveConfig { Id = 0, Size = 600, DriveId = "F", DisplayName = "OS Drive" });
            driveConfig.Add(new DriveConfig { Id = 0, Size = 300, DriveId = "G", DisplayName = "OS Drive" });
            driveConfig.Add(new DriveConfig { Id = 0, Size = 400, DriveId = "H", DisplayName = "OS Drive" });
            return new List<Request>
            {
                new Request {Id = 0, ServerName = "f6108ffe-e649-40e7-aaee-47d340811710", Requestor = "zjamaso0", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 20, Drives = driveConfig },
                new Request {Id = 1, ServerName = "8fa2237b-28ce-4051-b38c-b2f4de2a0adc", Requestor = "zjamaso1", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 9, RAM = 16, Drives = driveConfig },
                new Request {Id = 2, ServerName = "54e480a9-38ee-4b2d-a052-f44a65430023", Requestor = "zjamaso2", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 9, RAM = 12, Drives = driveConfig },
                new Request {Id = 3, ServerName = "599eb3df-7af0-4324-b2e4-f67bc5dbd36b", Requestor = "zjamaso3", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 9, RAM = 48, Drives = driveConfig },
                new Request {Id = 4, ServerName = "abf3531d-c103-48d8-a2e8-6c6817d68c17", Requestor = "zjamaso4", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 18, Drives = driveConfig },
                new Request {Id = 5, ServerName = "2e613a91-0cd9-4e7a-8203-1f476da95cfa", Requestor = "zjamaso5", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 3, RAM = 48, Drives = driveConfig },
                new Request {Id = 6, ServerName = "7c1fd3ab-d1a5-4d82-8fbb-7a4e46122ca3", Requestor = "zjamaso6", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 20, Drives = driveConfig },
                new Request {Id = 7, ServerName = "1419a985-e558-4a77-bb42-049f3a32075f", Requestor = "zjamaso7", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 20, Drives = driveConfig },
                new Request {Id = 8, ServerName = "eff0992e-cf37-4785-940e-5cf77f8be6c1", Requestor = "zjamaso8", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 8, Drives = driveConfig },
                new Request {Id = 9, ServerName = "3bb7da53-30b3-493a-b265-9dda5c2988cf", Requestor = "zjamaso9", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 8, Drives = driveConfig },
                new Request {Id = 10, ServerName = "e0cdb0ea-1fa7-474d-8cb8-fd8344609ad1", Requestor = "zjamaso10", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 44, Drives = driveConfig },
                new Request {Id = 11, ServerName = "0dcce7ed-0843-4168-915c-9e6a2c0f08a9", Requestor = "zjamaso11", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 9, RAM = 32, Drives = driveConfig },
                new Request {Id = 12, ServerName = "4922f040-a739-4988-8388-1f0c68fcb306", Requestor = "zjamaso12", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 28, Drives = driveConfig },
                new Request {Id = 13, ServerName = "c2c33b93-f215-42bb-b75d-4281f66c68d1", Requestor = "zjamaso13", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 36, Drives = driveConfig },
                new Request {Id = 14, ServerName = "fec7d148-42ab-4b62-83e8-a4053d335477", Requestor = "zjamaso14", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 32, Drives = driveConfig },
                new Request {Id = 15, ServerName = "2425061b-b240-4675-b858-8a046751096f", Requestor = "zjamaso15", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 10, RAM = 16, Drives = driveConfig },
                new Request {Id = 16, ServerName = "74014cd8-79ea-4ace-b28b-1d8e6ac038f6", Requestor = "zjamaso16", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 4, Drives = driveConfig },
                new Request {Id = 17, ServerName = "9e090db7-290c-49b6-b476-c99abd731cac", Requestor = "zjamaso17", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 36, Drives = driveConfig },
                new Request {Id = 18, ServerName = "1db91787-4ff1-41ae-995d-705b391dffd3", Requestor = "zjamaso18", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 32, Drives = driveConfig },
                new Request {Id = 19, ServerName = "b5001ef1-983d-4254-95a9-061e1a733087", Requestor = "zjamaso19", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 40, Drives = driveConfig },
                new Request {Id = 20, ServerName = "33d27f0f-6431-4752-9538-2893ecc7c583", Requestor = "zjamaso20", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 24, Drives = driveConfig },
                new Request {Id = 21, ServerName = "c713086b-aad4-44f6-af9a-14133759a54f", Requestor = "zjamaso21", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 20, Drives = driveConfig },
                new Request {Id = 22, ServerName = "6783cc28-fd47-4b59-a21b-04b45158ab6d", Requestor = "zjamaso22", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 10, RAM = 16, Drives = driveConfig },
                new Request {Id = 23, ServerName = "c3a6b4ae-966b-45eb-9dbd-ef9a91a096cd", Requestor = "zjamaso23", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 44, Drives = driveConfig },
                new Request {Id = 24, ServerName = "13327902-d0cb-4ea3-99cf-a77dfb16de69", Requestor = "zjamaso24", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 8, Drives = driveConfig },
                new Request {Id = 25, ServerName = "7871caf4-f776-4fdc-8b4d-bd6b9219ad2a", Requestor = "zjamaso25", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 32, Drives = driveConfig },
                new Request {Id = 26, ServerName = "acd48cf6-d8ba-4831-8a29-7b464fc79979", Requestor = "zjamaso26", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 28, Drives = driveConfig },
                new Request {Id = 27, ServerName = "5b594569-4049-4de8-ac0c-108b9e262f39", Requestor = "zjamaso27", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 9, RAM = 32, Drives = driveConfig },
                new Request {Id = 28, ServerName = "f3969fdb-84a1-4f41-b0b7-bf5dd0986b62", Requestor = "zjamaso28", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 48, Drives = driveConfig },
                new Request {Id = 29, ServerName = "ae2ff65e-90e7-438f-ab12-ff252304e8ae", Requestor = "zjamaso29", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 48, Drives = driveConfig },
                new Request {Id = 30, ServerName = "db42e913-0706-4d77-b132-3964b8dc2710", Requestor = "zjamaso30", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 9, RAM = 12, Drives = driveConfig },
                new Request {Id = 31, ServerName = "bc1a30ba-c75e-483c-a2ca-f87a0c9327b6", Requestor = "zjamaso31", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 3, RAM = 8, Drives = driveConfig },
                new Request {Id = 32, ServerName = "857c55ac-348d-445c-bb77-df05d1d7fbf8", Requestor = "zjamaso32", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 9, RAM = 36, Drives = driveConfig },
                new Request {Id = 33, ServerName = "1fa18132-da88-4170-96fa-b14a6c5d50ee", Requestor = "zjamaso33", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 3, RAM = 36, Drives = driveConfig },
                new Request {Id = 34, ServerName = "1a3557ef-6be1-483e-9d06-c70d6763d071", Requestor = "zjamaso34", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 4, Drives = driveConfig },
                new Request {Id = 35, ServerName = "615fcfbc-2aea-4593-9a82-a9b72e059065", Requestor = "zjamaso35", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 36, Drives = driveConfig },
                new Request {Id = 36, ServerName = "205b76b2-f6cb-409a-a7ab-db112754651f", Requestor = "zjamaso36", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 4, Drives = driveConfig },
                new Request {Id = 37, ServerName = "f7496c4f-f78b-4289-9d83-17dee105d402", Requestor = "zjamaso37", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 3, RAM = 28, Drives = driveConfig },
                new Request {Id = 38, ServerName = "2e071121-4522-4a23-9bb5-9d7e29ff477f", Requestor = "zjamaso38", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 20, Drives = driveConfig },
                new Request {Id = 39, ServerName = "e67d5188-fc37-4b3e-ab20-2d77702972e6", Requestor = "zjamaso39", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 20, Drives = driveConfig },
                new Request {Id = 40, ServerName = "97907fdf-1551-4f82-bb98-7fb0eb0da4b8", Requestor = "zjamaso40", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 44, Drives = driveConfig },
                new Request {Id = 41, ServerName = "4cd91427-fba3-428b-8493-8227ad875c9a", Requestor = "zjamaso41", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 9, RAM = 4, Drives = driveConfig },
                new Request {Id = 42, ServerName = "53cd2d1c-9d99-4146-978d-c970cc48ee9a", Requestor = "zjamaso42", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 3, RAM = 36, Drives = driveConfig },
                new Request {Id = 43, ServerName = "253d05bb-2339-4ee5-bb57-dfeb0eb6e46d", Requestor = "zjamaso43", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 9, RAM = 12, Drives = driveConfig },
                new Request {Id = 44, ServerName = "688276fb-5c4b-4c9c-9d79-8d4040a3e8da", Requestor = "zjamaso44", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 44, Drives = driveConfig },
                new Request {Id = 45, ServerName = "4110cd6d-7b75-4eba-8c3a-1782d53acc42", Requestor = "zjamaso45", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 36, Drives = driveConfig },
                new Request {Id = 46, ServerName = "fda604c7-310f-4475-b7c7-8facf70cb176", Requestor = "zjamaso46", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 28, Drives = driveConfig },
                new Request {Id = 47, ServerName = "bac99f97-9a93-407e-8575-41374b1e4682", Requestor = "zjamaso47", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 20, Drives = driveConfig },
                new Request {Id = 48, ServerName = "7c742c03-d624-4e99-ad76-81fd1c52938a", Requestor = "zjamaso48", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 44, Drives = driveConfig },
                new Request {Id = 49, ServerName = "2276a1ad-7e46-4470-b751-1498bfc6e70c", Requestor = "zjamaso49", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 28, Drives = driveConfig },
                new Request {Id = 50, ServerName = "3034e896-d641-47b8-b604-00b3627ab5d7", Requestor = "zjamaso50", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 10, RAM = 40, Drives = driveConfig },
                new Request {Id = 51, ServerName = "00abaa1e-7241-4b8b-9936-ab6bfd5b0dd1", Requestor = "zjamaso51", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 8, Drives = driveConfig },
                new Request {Id = 52, ServerName = "8d36e21f-bb70-498c-9e3b-331f6100817c", Requestor = "zjamaso52", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 4, Drives = driveConfig },
                new Request {Id = 53, ServerName = "d087350d-5ddd-4a01-a4db-e042f5a67b4c", Requestor = "zjamaso53", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 48, Drives = driveConfig },
                new Request {Id = 54, ServerName = "cfdf6369-7b7a-4474-b67e-4e61b2989925", Requestor = "zjamaso54", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 24, Drives = driveConfig },
                new Request {Id = 55, ServerName = "a7f68814-d757-4bc7-a752-8f47f6bae639", Requestor = "zjamaso55", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 44, Drives = driveConfig },
                new Request {Id = 56, ServerName = "56773844-29d9-41b3-90de-c262aa3746a9", Requestor = "zjamaso56", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 40, Drives = driveConfig },
                new Request {Id = 57, ServerName = "e3ad2fb8-cd98-4d1c-930a-9ff45ed6470e", Requestor = "zjamaso57", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 18, Drives = driveConfig },
                new Request {Id = 58, ServerName = "191afff1-aae8-4021-ac73-fdad6e83d0a8", Requestor = "zjamaso58", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 3, RAM = 20, Drives = driveConfig },
                new Request {Id = 59, ServerName = "ac65fb12-df21-492b-90ce-4bd2a1741812", Requestor = "zjamaso59", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 9, RAM = 8, Drives = driveConfig },
                new Request {Id = 60, ServerName = "eb6a1be0-8b8b-4b07-960c-a131ee2d5036", Requestor = "zjamaso60", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 3, RAM = 24, Drives = driveConfig },
                new Request {Id = 61, ServerName = "7ab70ac4-7761-4d38-bc63-e9c524fd7d34", Requestor = "zjamaso61", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 10, RAM = 20, Drives = driveConfig },
                new Request {Id = 62, ServerName = "26d7b8d5-918c-4e4f-a7a5-f4186e215a64", Requestor = "zjamaso62", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 18, Drives = driveConfig },
                new Request {Id = 63, ServerName = "16376c08-8b13-48ed-9b45-197b2514640b", Requestor = "zjamaso63", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 44, Drives = driveConfig },
                new Request {Id = 64, ServerName = "dabbb145-8667-4236-b376-0c0b243396be", Requestor = "zjamaso64", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 8, Drives = driveConfig },
                new Request {Id = 65, ServerName = "774e7328-5633-4221-8289-4964f22a60ca", Requestor = "zjamaso65", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 10, RAM = 32, Drives = driveConfig },
                new Request {Id = 66, ServerName = "62b8c7ed-464a-4365-8dd7-2c7877f8fd91", Requestor = "zjamaso66", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 8, Drives = driveConfig },
                new Request {Id = 67, ServerName = "56d1378e-6249-4e9c-98df-61535709a5c1", Requestor = "zjamaso67", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 3, RAM = 36, Drives = driveConfig },
                new Request {Id = 68, ServerName = "59298f8b-71bc-48d3-b251-e45f6f090b7d", Requestor = "zjamaso68", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 8, Drives = driveConfig },
                new Request {Id = 69, ServerName = "85c0c616-64b8-4f92-ba56-a693ed845659", Requestor = "zjamaso69", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 10, RAM = 32, Drives = driveConfig },
                new Request {Id = 70, ServerName = "08d2c9b4-f402-44c6-8cfb-ef5e7002994d", Requestor = "zjamaso70", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 8, Drives = driveConfig },
                new Request {Id = 71, ServerName = "a72568cf-ce80-4f16-a8e6-1da2329674ab", Requestor = "zjamaso71", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 12, Drives = driveConfig },
                new Request {Id = 72, ServerName = "1956155a-88c1-4f6b-aa58-fb60ddeefc6a", Requestor = "zjamaso72", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 12, Drives = driveConfig },
                new Request {Id = 73, ServerName = "642a4350-56a8-4c68-9f43-b055de63ab52", Requestor = "zjamaso73", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 12, Drives = driveConfig },
                new Request {Id = 74, ServerName = "5ec802f8-d5cc-4e34-9ad8-844597b9efab", Requestor = "zjamaso74", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 12, Drives = driveConfig },
                new Request {Id = 75, ServerName = "f49d5c90-8261-4e91-819f-5ce5b1ccb898", Requestor = "zjamaso75", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 16, Drives = driveConfig },
                new Request {Id = 76, ServerName = "59be1f2e-917c-4d59-b5e2-560689c638ed", Requestor = "zjamaso76", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 32, Drives = driveConfig },
                new Request {Id = 77, ServerName = "9d24ce32-47f3-4aae-93d8-5be82410a889", Requestor = "zjamaso77", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 28, Drives = driveConfig },
                new Request {Id = 78, ServerName = "2f7eba61-5eee-4985-971c-32b69dc72d4d", Requestor = "zjamaso78", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 40, Drives = driveConfig },
                new Request {Id = 79, ServerName = "7d1e9b68-6d28-4338-8e00-9766c286160e", Requestor = "zjamaso79", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 36, Drives = driveConfig },
                new Request {Id = 80, ServerName = "35c03e0e-c325-49ab-9188-6a9d2acf687f", Requestor = "zjamaso80", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 16, Drives = driveConfig },
                new Request {Id = 81, ServerName = "f45cf58d-2af8-4202-adb2-01d2097cb407", Requestor = "zjamaso81", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 28, Drives = driveConfig },
                new Request {Id = 82, ServerName = "805ac864-08a0-4651-8959-7df8f9758b7f", Requestor = "zjamaso82", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 7, RAM = 36, Drives = driveConfig },
                new Request {Id = 83, ServerName = "9dc6ab5e-62f6-4979-af04-7f300b9e04cd", Requestor = "zjamaso83", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 24, Drives = driveConfig },
                new Request {Id = 84, ServerName = "b4bda220-077c-41ae-9f03-c7ac6fb0f15f", Requestor = "zjamaso84", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 48, Drives = driveConfig },
                new Request {Id = 85, ServerName = "d9537965-cded-44c4-9b96-e616a6969ab4", Requestor = "zjamaso85", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 36, Drives = driveConfig },
                new Request {Id = 86, ServerName = "41dcd15a-1aa5-480a-af3f-4fb9f9049dd5", Requestor = "zjamaso86", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 8, RAM = 16, Drives = driveConfig },
                new Request {Id = 87, ServerName = "5521d0c4-f7ed-4835-b8ea-efe939834050", Requestor = "zjamaso87", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 28, Drives = driveConfig },
                new Request {Id = 88, ServerName = "9c50ea0e-70ce-4d8f-9119-b22700c3affc", Requestor = "zjamaso88", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 40, Drives = driveConfig },
                new Request {Id = 89, ServerName = "0d089194-76cd-4db7-8e12-58904ba6219a", Requestor = "zjamaso89", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 48, Drives = driveConfig },
                new Request {Id = 90, ServerName = "075a42b2-8ed5-4b92-9dfa-78e3c3242db9", Requestor = "zjamaso90", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 24, Drives = driveConfig },
                new Request {Id = 91, ServerName = "5cdfa7e3-0683-422b-a706-19adb0739df3", Requestor = "zjamaso91", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 20, Drives = driveConfig },
                new Request {Id = 92, ServerName = "5f20acec-4306-4739-bc53-0e54c2082673", Requestor = "zjamaso92", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 6, RAM = 12, Drives = driveConfig },
                new Request {Id = 93, ServerName = "4fd820d1-d023-4d6a-8419-7b8f7efec4e5", Requestor = "zjamaso93", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 44, Drives = driveConfig },
                new Request {Id = 94, ServerName = "0075483e-feaf-40f6-adc5-7dd5cd2da5d7", Requestor = "zjamaso94", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 36, Drives = driveConfig },
                new Request {Id = 95, ServerName = "afd6ac44-4114-47e9-b330-5560a7b4db65", Requestor = "zjamaso95", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 4, RAM = 32, Drives = driveConfig },
                new Request {Id = 96, ServerName = "993c6ffb-e9ec-49bf-85e4-b4c727903f94", Requestor = "zjamaso96", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 3, RAM = 4, Drives = driveConfig },
                new Request {Id = 97, ServerName = "d5e15d7d-64bf-453a-8541-5f1851fc68ae", Requestor = "zjamaso97", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 32, Drives = driveConfig },
                new Request {Id = 98, ServerName = "bd048303-2f5a-4b3c-b454-13851aa7354d", Requestor = "zjamaso98", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 2, RAM = 40, Drives = driveConfig },
                new Request {Id = 99, ServerName = "29f5adc3-ef75-486a-a196-0231ec044c30", Requestor = "zjamaso99", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 5, RAM = 8, Drives = driveConfig },
                new Request {Id = 100, ServerName = "0cd8d8ac-4716-4643-b43e-f4b95913aa36", Requestor = "zjamaso100", Domain = "Puget", Datacenter = "Bothel", OS = "2012r2", Cores = 3, RAM = 20, Drives = driveConfig }



            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Request value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
