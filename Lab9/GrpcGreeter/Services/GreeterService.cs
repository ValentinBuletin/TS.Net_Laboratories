using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcGreeter
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }

        public override Task<AddCommentResponse> AddComment(AddCommentRequest request, ServerCallContext context)
        {
            return base.AddComment(request, context);
        }

        public override Task<AddPostResponse> AddPost(AddPostRequest request, ServerCallContext context)
        {
            return base.AddPost(request, context);
        }

        public override Task<DeletePostResponse> DeletePost(DeletePostRequest request, ServerCallContext context)
        {
            return base.DeletePost(request, context);
        }

        public override Task<GetCommentByIdResponse> GetCommentById(GetCommentByIdRequest request, ServerCallContext context)
        {
            return base.GetCommentById(request, context);
        }

        public override Task<GetPostByIdResponse> GetPostById(GetPostByIdRequest request, ServerCallContext context)
        {
            return base.GetPostById(request, context);
        }

        public override Task<GetPostsResponse> GetPosts(GetPostsRequest request, ServerCallContext context)
        {
            return base.GetPosts(request, context);
        }

        public override Task<UpdateCommentResponse> UpdateComment(UpdateCommentRequest request, ServerCallContext context)
        {
            return base.UpdateComment(request, context);
        }

        public override Task<UpdatePostResponse> UpdatePost(UpdatePostRequest request, ServerCallContext context)
        {
            return base.UpdatePost(request, context);
        }
    }
}