FROM node

WORKDIR /app

COPY package.json .

RUN npm i

COPY . .

ARG DEFAULT_PORT=80
# 빌드(이미지 생성)시 값 변경하기
# docker build -t feedback-node:dev --build-arg DEFAULT_PORT=8000 .

# 환경변수 설정
ENV PORT $DEFAULT_PORT
# ENV PORT 80
# 실행하면서 환경변수 설정하는법
# docker run -d --rm -p 3000:8000 --env PORT=8000 --name feedback-app -v feedback:/app/feedback -v "C:\Users\KTW\Documents\GitHub\Udemy\Docker\data-volumes-01-starting-setup:/app:ro" -v /app/temp -v /app/node_modules feedback-app:env

# 환경변수 사용, $를 붙여야함
EXPOSE $POST

# VOLUME ["/app/feedback"]
# docker run -d -p 3000:80 --rm --name feedback-app -v feedback:/app/feedback feedback-node:volumes

# docker run -d --rm -p 3000:80 --name feedback-app -v feedback:/app/feedback -v "C:\Users\KTW\Documents\GitHub\Udemy\Docker\data-volumes-01-starting-setup:/app:ro" -v /app/temp -v /app/node_modules feedback-node:volumes
# CMD ["node", "server.js"]
CMD ["npm", "start"]
