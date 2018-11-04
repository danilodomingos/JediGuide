using System.Net;
using JediGuide.Rest;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace JediGuide.API.Controllers.Base
{
    public class BaseController : Controller
    {

        private readonly IDictionary<int, ObjectResult> actionsResult;

        public BaseController(): base()
        {
            this.actionsResult = GetActionResult();
        }

        public ActionResult Result<T>(Result<T> result)
        {
            ObjectResult action;

            this.actionsResult.TryGetValue(result.StatusCode, out action);

            if((int)HttpStatusCode.OK == result.StatusCode)
                action.Value = result.Data;
            else
                action.Value = result.Message;

            return action;
        }

        public ActionResult Result<T>(PaginatorResult<T> result)
        {
            var actionsResult = GetActionResult();
            ObjectResult action;

            actionsResult.TryGetValue(result.StatusCode, out action);

            if((int)HttpStatusCode.OK == result.StatusCode)
                action.Value = result.Page;
            else
                action.Value = result.Message;

            return action;
        }

        private IDictionary<int, ObjectResult> GetActionResult()
        {
            var actionsResult = new Dictionary<int, ObjectResult>();
            actionsResult.Add((int)HttpStatusCode.OK, Ok(new object()));
            actionsResult.Add((int)HttpStatusCode.Created, Ok(new object())); //Corrigir não está seguindo o REST
            actionsResult.Add((int)HttpStatusCode.BadRequest, BadRequest(new object()));
            actionsResult.Add((int)HttpStatusCode.NotFound, NotFound(new object()));
            actionsResult.Add((int)HttpStatusCode.Conflict, Conflict(new object()));

            return actionsResult;
        }
    }
}