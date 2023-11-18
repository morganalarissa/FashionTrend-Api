//using AutoMapper;
//using fashionTrend.Domain.Interfaces;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace fashionTrend.Application.UseCases.SupplierCases.DeleteSupplier
//{
//    public sealed class DeleteMessageHandler : IRequestHandler<DeleteMessageRequest, DeleteMessageResponse>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//       /// <summary>
//       /// //private readonly IMessageRepository _messageRepository;
//       /// </summary>
//        private readonly IMapper _mapper;

//        public DeleteMessageHandler(IUnitOfWork unitOfWork,
//                          //       IMessageRepository messageRepository, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _messageRepository = messageRepository;
//            _mapper = mapper;
//        }

//        public async Task<DeleteMessageResponse> Handle(DeleteMessageRequest request,
//                                                     CancellationToken cancellationToken)
//        {

//            var message = await _messageRepository.Get(request.Id, cancellationToken);

//            if (message == null) return default;

//            _messageRepository.Delete(message);
//            await _unitOfWork.Commit(cancellationToken);

//            return _mapper.Map<DeleteMessageResponse>(message);
//        }
//    }
//}
