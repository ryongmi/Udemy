FROM node

WORKDIR /app

COPY package.json /app

RUN npm i

COPY . /app

EXPOSE 80

CMD ["node", "server.js"]

# 해당 이미지를 기반으로 생성한 컨테이너 실행 명령어 
# docker run -p 3000:80 a5913d24109926d17cabdf0ce54538917e0f87f5c2b0d2087f3688ea5994f7e8