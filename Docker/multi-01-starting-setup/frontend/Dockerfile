FROM node

WORKDIR /app

COPY package.json .

RUN npm i

COPY . .

EXPOSE 3000

CMD ["npm", "start"]

# docker run -v /app/src -v "C:\Users\KTW\Documents\GitHub\Udemy\Docker\multi-01-starting-setup\frontend\src:/app/src" --name goals-frontend --rm -p 3000:3000 -it goals-react 