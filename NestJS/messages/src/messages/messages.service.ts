import { Injectable } from '@nestjs/common';
import { MessagesRepository } from './messages.repository';

@Injectable()
export class MessagesService {
  // messagesRepo: MessagesRepository;

  // constructor() {
  //   // 이렇게 만들면 의존성이 생겨서 Nest에서는 사용하지 않음
  //   this.messagesRepo = new MessagesRepository();
  // }

  constructor(public messagesRepo: MessagesRepository) {}

  findOne(id: string) {
    return this.messagesRepo.findOne(id);
  }

  findAll() {
    return this.messagesRepo.findAll();
  }

  create(content: string) {
    return this.messagesRepo.create(content);
  }
}
