FROM node

WORKDIR /app

COPY package.json .

RUN npm i

COPY . .

EXPOSE 80

ENV MONGODB_USERNAME=root
ENV MONGODB_PASSWORD=secret

CMD ["npm", "start"]

# docker run --name mongodb -v data:/data/db --rm -d --net goals-net -e MONGO_INITDB_ROOT_USERNAME=max -e MONGO_INITDB_ROOT_PASSWORD=secret mongo
# docker run --name goals-backend -v "C:\Users\KTW\Documents\GitHub\Udemy\Docker\multi-01-starting-setup\backend:/app" -v logs:/app/logs -v /app/node_modules -e MONGODB_USERNAME=max -e MONGODB_PASSWORD=secret --rm -d --net goals-net -p 80:80 goals-node