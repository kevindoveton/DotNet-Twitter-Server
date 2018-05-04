interface iUser {
  name: string,
  username: string,
  id: string
}

interface iNewsfeedRes {
  dateTime: string,
  text: string,
  id: number,
  user: iUser
}

interface iTweetProps {
  tweet: iNewsfeedRes,
  user: iUser
}

interface iNewsfeed {
  tweets: Array<iTweetProps>
}

interface iPropMatch {
  path: string,
  isExact: boolean,
  url: string,
  params: {
    id?: number
  }
}