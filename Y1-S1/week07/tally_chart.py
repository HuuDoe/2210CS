candidate_names = [chr(c) for c in range(ord('A'), ord('A') + 5)]

vote = {}
vote_received = False

def vote_prompt():
    global vote
    user_vote = ''
    while user_vote.strip().upper() not in candidate_names and user_vote.strip() != '-1':
        user_vote = input('Your vote: ').strip().upper()
    vote_received = True
    if user_vote == '-1':
        if vote_received:
            print('*' * 30)
            print('The winner is Candidate', list(vote.keys())[0])
            exit()
        else:
            print('No vote received yet!')
    else:
        vote[user_vote] += 1


def candidates_sort_ac_votes(vote: dict):
    sorted_vote_result = sorted(vote.values())[::-1]
    sorted_vote_list = {}
    for sort_result in sorted_vote_result:
        for candidate, result in vote.items():
            if result == sort_result:
                sorted_vote_list[candidate] = result
    return sorted_vote_list
    

def vote_results(vote: dict):
    print('Name', 'Vote', sep='\t|\t')
    print(25 * '-')
    for candidate, result in vote.items():
        print(f' {candidate}', f' {result}', sep='\t|\t')
    


def main():
    global vote
    for id in candidate_names:
        vote[id] = 0
    while True:
        vote_results(vote)
        # print(vote)
        vote_prompt()
        vote = candidates_sort_ac_votes(vote)

main()