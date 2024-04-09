// nest generate controller messages/messages --flat
// --flat을 빼고 실행하면 controller 폴더를 하나 생성해서 거기에 contorller 관련 파일 생성함

import {
  Controller,
  Get,
  Post,
  Body,
  Param,
  NotFoundException,
} from '@nestjs/common';
import { CreateMessageDto } from './dtos/create-message.dto';
import { MessagesService } from './messages.service';

@Controller('messages')
export class MessagesController {
  // messagesService: MessagesService;

  // constructor() {
  //   this.messagesService = new MessagesService();
  // }

  constructor(public messagesService: MessagesService) {}

  @Get()
  listMessages() {
    return this.messagesService.findAll();
  }

  @Post()
  createMessage(@Body() body: CreateMessageDto) {
    return this.messagesService.create(body.content);
  }

  @Get('/:id')
  async getMessage(@Param('id') id: string) {
    const message = await this.messagesService.findOne(id);

    if (!message) {
      throw new NotFoundException('messages not found');
    }

    return message;
  }
}
